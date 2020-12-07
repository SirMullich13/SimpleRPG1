using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AmountToHeal's data type will be an integer because hit points are in discrete units and not decimals
//the properties on the HealingPotion class are ID, Name, NamePlural, and AmountToHeal
//some of the classes have similar properties and represent the same type of thing...
//e.g. HealingPotion, Item, and Weapon classes all represent items that a player may collect during a game
//when you have classes that have these things in common, you may want to use inheritance, another aspect of OOP
namespace Engine
{
    //we'll make Item the base (aka parent) class for the HealingPotion, so HealingPotion will inherit from Item class
    //HealingPotion is now a derived (aka child) class from the Item class
    public class HealingPotion : Item
    {
        //so now all the public properties and methods from the Item class automatically appear in the HealingPotion class,
        //even after we delete the lines previously containing ID, Name, and NamePlural properties
        public int AmountToHeal { get; set; }

        //create a constructor that will make healing potion objects
        //this constructor has parameters for the one property it has in the class,
        //and three properties it uses from the base class (ID, Name, and NamePlural)
        //this last part is taking the values from the parameters in the healing potion constructor
        //and passing them on to the constructor of the Item class
        //this is how we get parameters into the base class, when instantiating a derived class
        public HealingPotion (int id, string name, string namePlural, 
            int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
    //now we've created the HealingPotion class. Once your program instantiates or creates a healing potion object,
    //it will be able to read and change the value of the object's properties
}
