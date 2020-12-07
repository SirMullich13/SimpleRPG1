using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this class represents monsters in your game
namespace Engine
{
    //the monster class inherits from the living creature base class
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List <LootItem> LootTable { get; set; }

        //create a constructor that makes monster objects
        //the last part passes the values of the parameters in the monster constructor,
        //and passes them on to the constructor of the living creature class
        //this is how we get parameters into the base class, when instantiating a derived class
        public Monster (int id, string name, int maximumDamage, int rewardExperiencePoints, 
            int rewardGold, int currentHitPoints, int maximumHitPoints) : base (currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}
//now when your program instantiates a monster object, it will be able to
//read and change the value of the object's properties.
