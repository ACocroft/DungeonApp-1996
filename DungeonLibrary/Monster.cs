using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //Props
        //MinDamage int - Field - Business Rule : > 0 && < MaxDamage
        //MaxDamage int
        //Description string
        #region Potential Expansion
        //Add a WeaponType for a weakness. Or a resistance. Or both. If you care.
        //You could then add functionality to tomorrow's combat class to deal additional damage
        //if the monster is weak to the weapon you have
        #endregion

        //Fields
        private int _maxDamage;
        private int _damage;

        //Properties
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set
            {
                if (value > _maxDamage)
                    _damage = _maxDamage;
                else
                    _damage = value;
            }

        }//end props
        public string Description { get; set; }
        //Constructor
        public Monster (string name, int hitChance, int block, int maxLife, int maxDamage, int damage, string description)
            : base(name,
                 hitChance,
                 block,
                 maxLife)
        {
            MaxDamage = maxDamage;
            Damage = damage;
            Description = description;
        }

        public Monster()
        {
        }
        public override string ToString()
        {
            return $"{Name}\n" +
                $"Life: {Life} / {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}%";
        }

        //default ctor so we can have default monsters later

        //Override the ToString() to include your new custom props.
        //Override CalcDamage()
        public override int CalcDamage()
        {
            //return a random number between your min and max damage properties.
            throw new NotImplementedException();
        }
    }
}
