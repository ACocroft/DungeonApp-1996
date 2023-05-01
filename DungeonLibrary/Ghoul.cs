using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Ghoul : Monster
    {
        private bool _isArchGhoul;
        public bool IsArchGhoul
        {
            get { return _isArchGhoul;}
            set { _isArchGhoul = value;}
        }

        public string Description { get; set; }

        public Ghoul(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isArchGhoul)
            : base(name,
                 hitChance,
                 block,
                 maxLife,
                 maxDamage,
                 minDamage,
                 description
                 )
        {
            IsArchGhoul = isArchGhoul;
        }
        public Ghoul()
        {
            MaxLife = 5;
            MaxDamage = 25;
            Name = "Arch Ghoul";
            Life = 5;
            HitChance = 25;
            Block = 5;
            MinDamage = 7;
            Description = " Watch out!";
            IsArchGhoul = true;
        }
        public override string ToString()
        {
            return base.ToString() + (IsArchGhoul ? "A freakish albino variant" : "Jackal Men feasting on the dead.");
        }
        public override int CalcDamage()
        {
            int calculatedDamage = MaxDamage;

            if (IsArchGhoul)
            {
                calculatedDamage += calculatedDamage / 2;
            }
            //return a random number between your min and max damage properties.
            return calculatedDamage;
        }
    }
}
