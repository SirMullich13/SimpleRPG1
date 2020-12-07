using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //the player class inherits from the living creature base class
    public class Player : LivingCreature
    {
        //one of the behaviors required of the Player object is to get (read) and set (write or store a value) of the player's various attributes
        //so each attribute below like Gold and Level has corresponding methods, e.g. getGold() and setGold()
        //this is so when another object (say within the SuperAdventure UI) needs info like how much Gold the player has, it can send
        //a message to the Player object and ask what its gold value is.
        //the syntax below is called auto-implemented properties but they could we written in a longer less streamlined way.
        //why use properties? B/c you can control access to the various attributes like Gold in the Player object
        //this is an advantage of OO Programming, where no object should be able to manipulate and change the data within another object.
        //in .NET techniques, the getters and setters are considered properties of the attributes themselves, like Gold and Level

        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        /* add two new properties to hold lists containing InventoryItem
         * and PlayerQuest objects.*/
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        public Location CurrentLocation { get; set; }

        //create a constructor that makes player objects
        public Player(int currentHitPoints, int maximumHitPoints,
            int gold, int experiencePoints, int level) : 
            base (currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            /* add two new properties to set the value of the new properties
             * to empty lists. Without this, their default value would be
             * null, or nothing. We can add items to them later, b/c you
             * can add objects to an empty list. But you can't add objects
             * to nothing.*/
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }

        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if(location.ItemRequiredToEnter == null)
            {
                //There is no required item for this location,
                //so return "true"
                return true;
            }

            //See if the player has the required item in
            //their inventory
            foreach(InventoryItem ii in Inventory)
            {
                if(ii.Details.ID == location.ItemRequiredToEnter.ID)
                {
                    //We found the required item, so return "true"
                    return true;
                }
            }

            //We didn't find the required item in their inventory,
            //so return "false"
            return false;
        }

        public bool HasThisQuest(Quest quest)
        {
            foreach(PlayerQuest playerQuest in Quests)
            {
                if(playerQuest.Details.ID == quest.ID)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CompletedThisQuest(Quest quest)
        {
            foreach(PlayerQuest playerQuest in Quests)
            {
                if(playerQuest.Details.ID == quest.ID)
                {
                    return playerQuest.IsCompleted;
                }
            }

            return false;
        }

        public bool HasAllQuestCompletionItems(Quest quest)
        {
            //See if the player has all the items needed
            //to complete the quest here
            foreach(QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                bool foundItemInPlayersInventory = false;

                //Check each item in the player's inventory,
                //to see if they have it, and enough of it
                foreach(InventoryItem ii in Inventory)
                {
                    //The player has the item in their inventory
                    if(ii.Details.ID == qci.Details.ID)
                    {
                        foundItemInPlayersInventory = true;
                        //The player does not have enough of this item
                        //to complete the quest
                        if(ii.Quantity < qci.Quantity)
                        {
                            return false;
                        }
                    }
                }

                //The player does not have any of this quest
                //completion item in their inventory
                if(!foundItemInPlayersInventory)
                {
                    return false;
                }
            }

            //If we got here, then the player must have all the required
            //items, and enough of them, to complete the quest.
            return true;
        }

        public void RemoveQuestCompletionItems(Quest quest)
        {
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                foreach (InventoryItem ii in Inventory)
                {
                    if(ii.Details.ID == qci.Details.ID)
                    {
                        // Subtract the quantity from the player's 
                        // inventory that was needed to complete the quest
                        ii.Quantity -= qci.Quantity;
                        break;
                    }
                }
            }
        }

        public void AddItemToInventory(Item itemToAdd)
        {
            foreach(InventoryItem ii in Inventory)
            {
                if(ii.Details.ID == itemToAdd.ID)
                {
                    // They have the item in their inventory, so increase
                    // the quantity by one
                    ii.Quantity++;

                    return; // We added the item, and are done, so get out
                            // out of this function
                }
            }
            // They didn't have the item, so add it to their inventory,
            // with a quantity of 1
            Inventory.Add(new InventoryItem(itemToAdd, 1));
        }

        public void MarkQuestCompleted(Quest quest)
        {
            // Find the quest in the player's quest list
            foreach(PlayerQuest pq in Quests)
            {
                if(pq.Details.ID == quest.ID)
                {
                    // Mark it as completed
                    pq.IsCompleted = true;

                    // We found the quest, and marked it as complete, so get
                    // out of this function
                    return;
                }
            }
        }

    }
}
//now we've created the Player class. Once your programs creates (instantiates) a Player object, it will be able to read
//and change the values of the object's properties
