using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class ApeDemon : Monster
    {

        //Fields
        private bool _isRed;

        //Properties
        public bool IsRed
        {
            get { return _isRed; }
            set { _isRed = value; }
        }
        public string Description { get; set; }
        //Constructor
        public ApeDemon(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isRed)
            : base(name,
                 hitChance,
                 block,
                 maxLife,
                 maxDamage,
                 minDamage,
                 description
                 )
        {
            IsRed = isRed;
        }

        public ApeDemon()
        {
            MaxLife = 20;
            MaxDamage = 10;
            Name = "Dark Ape Demon";
            Life = 20;
            HitChance = 70;
            Block = 20;
            MinDamage = 2;
            Description = " A more feral ape demon, if such a thing could exist!";
            IsRed = false;
        }

        //default ctor so we can have default monsters later

        //Override the ToString() to include your new custom props.
        //Override CalcDamage()
        public override string ToString()
        {
            return base.ToString() + (IsRed ? "Thick red fur drapes its hide" : "Jet" +
                "Black hairs from the abyss itself");
        }
        public override int CalcDamage()
        {
            int calculatedDamage = MinDamage;

            if (IsRed)
            {
                calculatedDamage += calculatedDamage / 2;
            }
            //return a random number between your min and max damage properties.
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
    }
}
