using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Make it public
    public class Weapon
    {
        /* 
         Make fields and props for each of these with the appropriate naming conventions.
         Business rule on MinDamage, can't be more than MaxDamage, or less than 1. If it is, default it to 1.
            
        
            minDamage – int
            maxDamage – int
            name – string
            bonusHitChance – int
            isTwoHanded - bool
         
         */

        //funny
        //FIELDS
        //people
        //PROPERTIES
        //collect
        //CONSTRUCTORS
        //monkeys 
        //METHODS

        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded; 

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage <= MaxDamage ? minDamage : MaxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }

        public override string ToString()
        {
            return $"{Name}\t{MinDamage} to {MaxDamage} Damage\n" +
                $"Bonus Hit: {BonusHitChance}%\n" +
                $"{(IsTwoHanded ? "Two" : "One" )
        }

        public Weapon()
        {
        }
    }
}
