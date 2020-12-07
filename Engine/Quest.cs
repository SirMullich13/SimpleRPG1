using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this class will represent and model the quests in the game
//added a RewardItem property to store what Item the player receives
//for completing a quest. This property uses the Item class as its
//data type b/c we need to store an Item object in the RewardItem property,
//so its data type is Item.
namespace Engine
{
    public class Quest
    {
        public Item RewardItem { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        //create a constructor that will make Quest objects
        //assign the values of the parameters on the properties in the class
        //now the Quest class has a custom constructor that accepts values to set its properties
        //we are essentially saying "I need these values before I can create this object..."
        public Quest(int id, string name, string description,
            int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    } 
}
//now when the program instantiates a quest object, it will be able to
//read and change the value of the object's properties.
