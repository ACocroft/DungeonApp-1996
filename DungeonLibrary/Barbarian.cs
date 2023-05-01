using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Barbarian : Monster
    {
        //Fields
        private bool _isArmored;

        //Properties
        public bool IsArmored
        {
            get { return _isArmored; }
            set { _isArmored = value; }
        }
        public string Description { get; set; }
        //Constructor
        public Barbarian(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isArmored)
            : base(name,
                 hitChance,
                 block,
                 maxLife,
                 maxDamage,
                 minDamage,
                 description
                 )
        {
            IsArmored = isArmored;
        }

        public Barbarian()
        {
            MaxLife = 35;
            MaxDamage = 8;
            Name = "Ofirian SellSword";
            Life = 20;
            HitChance = 20;
            Block = 70;
            MinDamage = 1;
            Description = " A heavily armored mercenary from the sister country of Ofir";
            IsArmored = true;
        }

        //default ctor so we can have default monsters later

        //Override the ToString() to include your new custom props.
        //Override CalcDamage()
        public override string ToString()
        {
            return base.ToString() + (IsArmored ? "The torn brigandine shuffles plates of steel" +
                "under the binding leather." : "The savage hillman wears only winter clothes");
        }
        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsArmored)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            //return a random number between your min and max damage properties.
            return calculatedBlock;
        }
    }
}
