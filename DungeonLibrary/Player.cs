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
        public RaceEnums PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        

        public Player(string name, int hitChance, int block, int maxLife,
            RaceEnums playerRace, Weapon userChoice)
            : base(name,
                   hitChance,
                   block,
                   maxLife)
        {
            PlayerRace = playerRace;
            EquippedWeapon = userChoice;

            #region Possible expansion - Racial Bonuses
            //In program.cs, you will have to show the user a list of races and let them pick one. Send it back to the
            //player constructor. The reference for his is in your CSF2 Enums.cs for ClassicMonsters.
            switch (playerRace)
            {
                case RaceEnums.Cimmerian:
                    MaxLife += 5;
                    Life = MaxLife;
                    Block += 5;
                    break;
                case RaceEnums.Shemite:
                    HitChance += 10;
                    break;
                case RaceEnums.Kushite: 
                    Block += 10;
                    break;
                case RaceEnums.Stygian:
                    HitChance += 5;
                    MaxLife += 5;
                    Life = MaxLife;
                    break;
                case RaceEnums.Himelian:
                    MaxLife += 10;
                    Life = MaxLife;
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
                case RaceEnums.Cimmerian:
                    raceDescription = "Barbarians of the grey lands";
                    break;
                case RaceEnums.Shemite:
                    raceDescription = "Fierce bowmen";
                    break;
                case RaceEnums.Kushite:
                    raceDescription = "Mysterious and devout";
                    break;
                case RaceEnums.Stygian:
                    raceDescription = "Cunning and merciless";
                    break;
                case RaceEnums.Himelian:
                    raceDescription = "Strong and hardy";
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
