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

        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _weaponType;

        //people
        //PROPERTIES


        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value < MaxDamage && value > 0 ? value : 1; }
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
        public WeaponType WeaponType
        {
            get { return _weaponType; }
            set { _weaponType = value; }
        }

        //collect
        //CONSTRUCTORS
        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded, WeaponType weaponType)

        //monkeys 
        //METHODS
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            WeaponType = weaponType;
        }


        public override string ToString()
        {
            return $"{Name}\n" +
                $"Maximum Damage: {MaxDamage}\n" +
                $"Minimum Damage: {MinDamage}\n" +
                $"Bonus Hits Chance: {BonusHitChance}\n" +
                $"{(IsTwoHanded ? "Two" : "One")}-Handed\n" +
                $"Weapon Type: {WeaponType.ToString().Replace('_', ' ')}";
        }
        public int CalculateMinDamage()
        {
            return MinDamage;
        }

        public int CalculateMaxDamage()
        {
            return MaxDamage;
        }
        public Weapon()
        {

        }

    }
}
