using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class WeaponEnums
    {
        static void Main(string[] args)
        {
            Console.Write("The tool with which you shall crush your enemies and see them" +
                          " driven before you!");

            Console.WriteLine("My weapon of choice was the " + WeaponType.Scimitar);
            //Because enums are NOT collections, we cannot iterate through them in a foreach directly.
            //However, we can use a .GetValues() static method from the Enum class to pull all of the
            //values of a certain enum type into an array.
            WeaponType[] weapons = Enum.GetValues<WeaponType>();
            //.GetValues(typeof(WeaponType))
            foreach (WeaponType item in weapons)
            {
                Console.WriteLine($"{(int)item + 1} - {item}");
            }
            Console.WriteLine("\nWith what device will you apply your practice? (enter the number only):");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            WeaponType userWeapon = (WeaponType)(userChoice - 1);

            switch (userWeapon)//switch + tab+tab, "userMonster", then Enter twice
            {
                case WeaponType.Scimitar:
                    Console.WriteLine("\nFor the dexteritous in nature.");
                    break;
                case WeaponType.Broadsword:
                    Console.WriteLine("\nThe reliable all-arounder.");
                    break;
                case WeaponType.Greatsword:
                    Console.WriteLine("\nStrength and agility combined.");
                    break;
                case WeaponType.Axe:
                    Console.WriteLine("\nA brutal one handed splitter.");
                    break;
                case WeaponType.Fists:
                    Console.WriteLine("\nBarbarous!");
                    break;
                default:
                    break;
            }
        }
    }
}
