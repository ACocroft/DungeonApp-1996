using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class SetCultist : Monster
    {
        private bool _isLich;
        public bool IsLich
        {
            get { return _isLich; }
            set { _isLich = value; }
        }
        public string Description { get; set; }
        //Constructor
        public SetCultist(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isLich)
            : base(name,
                 hitChance,
                 block,
                 maxLife,
                 maxDamage,
                 minDamage,
                 description
                 )
        {
            IsLich = isLich;
        }
        public SetCultist()
        {
            MaxLife = 80;
            MaxDamage = 15;
            Name = "Lich of Set";
            Life = 80;
            HitChance = 50;
            Block = 20;
            MinDamage = 5;
            Description = " The fell priest of Set";
            IsLich = true;
        }
        public override string ToString()
        {
            return base.ToString() + (IsLich ? "A gold and black Stygian robe beneath a\n" +
                " deathshead of mail coif and golden crown." : "Silk white robes and a fierce\n" +
                " snake mask of clay");
        }
        public override int CalcHitChance()
        {
            int calculatedHitChance = HitChance;

            if (IsLich)
            {
                calculatedHitChance += calculatedHitChance / 2;
            }
            //return a random number between your min and max damage properties.
            return calculatedHitChance;
        }
    }
}
