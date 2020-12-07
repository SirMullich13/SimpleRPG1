using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this class will represent living creatures in the game
//creating a new class for living creatures, which will be the base or parent class for Monster and Player classes
namespace Engine
{
    //making class parent so its child classes can access it
    public class LivingCreature
    {
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

        //create a constructor that will make living creature objects
        //assign the values of the parameters to the properties in the class
        //now we are saying "I need these values to create a living creature object"
        public LivingCreature (int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }
    }
}
