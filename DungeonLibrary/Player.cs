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
        private bool raceChosen;

        public RaceEnums PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        

        public Player(string name, int hitChance, int block, int maxLife,
            RaceEnums raceChosen, Weapon equippedWeapon)
            : base(name,
                   hitChance,
                   block,
                   maxLife)
        {
            PlayerRace = raceChosen;
            EquippedWeapon = equippedWeapon;

            #region Possible expansion - Racial Bonuses
            //In program.cs, you will have to show the user a list of races and let them pick one. Send it back to the
            //player constructor. The reference for his is in your CSF2 Enums.cs for ClassicMonsters.
            //switch (PlayerRace)
            //{
            //    case RaceEnums.Cimmerian:
            //}
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
                case RaceEnums.Cimmerian:
                    raceDescription = 
                                  $"Barbarians of the grey lands\n" +
                                  $"--------------------\n";
                    break;
                case RaceEnums.Shemite:
                    raceDescription = 
                                  $"Fierce bowmen\n" +
                                  $"--------------------\n";
                    break;
                case RaceEnums.Kushite:
                    raceDescription = 
                                  $"Mysterious and devout\n" +
                                  $"--------------------\n";
                    break;
                case RaceEnums.Stygian:
                    raceDescription = 
                                  $"Cunning and merciless\n" +
                                  $"--------------------\n" ;
                    
                    break;
                case RaceEnums.Himelian:
                    raceDescription = 
                                  $"Strong and hardy\n" +
                                  $"--------------------";
                    
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
