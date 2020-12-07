using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this is a class representing Items in the game that the player can collect
//it shares three of the same properties with each of the HealingPotion and Weapon classes
//thus we make it the base (aka parent) class for the HealingPotino and Weapon classes
namespace Engine
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }

        //create a constructor that will make Item objects
        //assign the values of the parameters to the properties in the class
        //now we are saying "I need these values to create an Item object"
        public Item (int id, string name, string namePlural)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
        }
    }
}

