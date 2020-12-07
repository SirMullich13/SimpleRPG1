using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this weapon class will represent weapons that the player can use to attack monsters
//this class shares three of the same properties with each of the HealingPotion and Item classes
namespace Engine
{
    //Weapon inherits from the Item class because it shares common properties and 
    //represents the same type of things (things you can collect)
    //delete the lines with the three properties that were previously displayed in the Item class
    //so now the weapon class only has its unique properties it does not share with its parent class, Item
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        //create a constructor that will make weapon objects
        //the last part passes the values of the parameters in the weapon constructor
        //and passes them on to constructor of the Item class
        //this is how get parameters into the base class, when instantiating a derived class
        public Weapon (int id, string name, string namePlural, int minimumDamage, int maximumDamage) : base(id, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
//now once your program instantiates weapon objects, it will be able to read and change
//the values of the object's properties.
