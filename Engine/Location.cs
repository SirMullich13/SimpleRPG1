using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this class represents the player's location in the game world
namespace Engine
{
    public class Location
    {
        //we want to potentially store an item required to enter the location,
        //such as a key. And if a quest is available at the location, we need
        //to store that value. A monster may exist in the location.
        //So we add new properties to the Location class to store these values
        //Here, these properties use one of our other classes as its data type.
        //E.g. b/c we need to store an Item object in the ItemRequiredToEnter
        //property, its datatype is Item

        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //create a constructor that will make Location objects
        //assign the values of the parameters to the properties in the class
        //the parameters (lower-case) are all on the right of the equal sign,
        //and the properties (mixed-case) are on the left
        //after the last three parameters there is = null,
        //this is b/c some locations won't have an item required to enter them,
        //a quest available, or a monster living there.
        //=null lets you call Location constructor without passing those 3 values
        public Location (int id, string name, string description,
            Item itemRequiredToEnter = null,
                Quest questAvailableHere = null,
                    Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }
    }
}
//now when your program instantiates location objects, it will be able to
//read and change the values of the object's properties.
