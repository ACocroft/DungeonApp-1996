using System;
using DungeonLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace DungeonClass
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            //Character player = new Character();
           // player.Life = 90;
           // player.MaxLife = 100;
            //player.Name = "Player 1";
           // player.HitChance = 80;
           // player.Block = 60;



            Weapon weapon = new Weapon();
            weapon.MaxDamage = 100;
            weapon.MinDamage = 100;
            weapon.BonusHitChance = 100;
            weapon.Name = "Weapon Name";
            weapon.IsTwoHanded = true;

            //Console.WriteLine($"You, {player.Name}, have braved the Honorless Wood with" +
           //     $"only a {weapon.Name} at your side. To best the foes" +
           //     $" within, will such a thing save you then?");
            Console.WriteLine("Max damage: " + weapon.MaxDamage);
            Console.WriteLine("Min damage: " + weapon.MinDamage);
            Console.WriteLine("Bonus Hit Chance: " + weapon.BonusHitChance);
            Console.WriteLine("You're carrying a: " + weapon.IsTwoHanded + " weapon.");
            Console.WriteLine(weapon);

            //TODO Test player creation and ToString(), calcblock, calcdamage, calchitchance
            //TODO Test monster creation and ToString(), calcblock, calcdamage, calchitchance
            Character[] characters = { new Player(), new Monster() };

        }//end Main()
    }//class
}//end namespace
