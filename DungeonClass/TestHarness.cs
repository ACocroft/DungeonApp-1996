//using System;
//using DungeonLibrary;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Reflection.Metadata;

//namespace DungeonClass
//{
//    internal class TestHarness
//    {
//        static void Main(string[] args)
//        {
//            Weapon w1 = new Weapon("Broadsword", 1, 4, 0, false, WeaponType.Broadsword);
//            Player player = new Player("Conan", 80, 50, 100, RaceEnums.Cimmerian, w1);
//            Monster m1 = new Monster("Ape Demon", 50, 40, 10, 4, 1, "A hellish abomination from the planes of madness!");

//            while (player.Life > 0 && m1.Life > 0)
//            {
//                Combat.DoBattle(player,m1);
//                Console.WriteLine("Player Life: " + player.Life);
//                Console.WriteLine("Monster Life: " + m1.Life);
//                Console.ReadKey();
//                Console.Clear();
//            }
//            if (player.Life <=0)
//            {
//                Console.WriteLine("Crom laughs at you, laughs from his mountain!");
//            }
          




//        }//end Main()
//    }//class
//}//end namespace
