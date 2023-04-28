using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //make it public
    //make it a child of Character by adding : Character
    public class Player : Character
    {
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Player(string name, int hitChance, int block, int maxLife, Race playerRace, Weapon equippedWeapon)
            : base(name,
                   hitChance,
                   block,
                   maxLife)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Possible expansion - Racial Bonuses
            //In program.cs, you will have to show the user a list of races and let them pick one. Send it back to the
            //player constructor. The reference for his is in your CSF2 Enums.cs for ClassicMonsters.
            switch (playerRace)
            {
                case Race.Cimmerian:
                    MaxLife += 10;
                    Life = MaxLife;
                    break;
                case Race.Shemite:
                    HitChance += 5;
                    break;
                case Race.Kushite: 
                    break;
                case Race.Stygian:
                    break;
                case Race.Himelian:
                    break;
            }

            #endregion
        }//end CTOR
        public Player()
        {

        }
        public override string ToString()
        {
            string raceDescription = "";
            switch (PlayerRace)
            {
                case Race.Cimmerian:
                    raceDescription = "Barbarians of the grey lands";
                    break;
                case Race.Shemite:
                    break;
                case Race.Kushite:
                    break;
                case Race.Stygian:
                    break;
                case Race.Himelian:
                    break;
                default:
                    break;

            }
            return base.ToString() + $"\nWeapon: {EquippedWeapon.Name}\n" +
                        $"Description: \n{raceDescription}";
        }
        public override int CalcDamage()
        {
            return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }
        public override int CalcHitChance()
        {
            //     HitChance + EquippedWeapon.BonusHitChance;
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
            //HitChance - Block = chance that you hit.
            //Roll a random number between 1 and 100. If it's less than the hit chance, we hit.
        }
    }
}
