using DungeonLibrary;

namespace DungeonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction
            //Start Background Music? (.wav) < 100mb, cannot control volume so turn headphones down
            //System.Windows.Extensions (NuGet package)
            Console.Title = "Harrowed Halls";
            Console.WriteLine("You cleft your way through the Forest of Thorns Without Honor, and into the halls of the decrepit university from which evil ravages Nemedia. The foul snake lich lies ahead. Do not dare return without his skull.");

            #endregion

            //Variable to keep score
            //Potential expansion, use "money" instead of a score to let user buy potions or whatever.
            int score = 0;
            //Weapon object creation

            Weapon wep = new("Broadword", 1, 8, 10, false, WeaponType.Broadsword);
            //Potential expansion: Show user list of weapons and let them pick one, or assign one at random.

            //Player object creation
            //Recommended Expansion - Player Customization. Pick a name and race.
            Player player = new("Conan", 60, 15, 40, Race.Cimmerian, wep);
            //Main Game Loop
            bool lose = false;
            do
            {
                //Generate a room
                Console.WriteLine(GetRoom());
                Monster monster = GetMonster();
                Console.WriteLine("In this room, a " +monster.Name + " skulks about!");

                #region Main Menu Loop
                //Encounter/Menu Loop
                bool reload = false;
                do
                {
                    //print the menu
                    Console.WriteLine("\nPlease choose an action: \n" +
                        "A) Strike\n" +
                        "R) Retreat\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Sever your fate\n");
                    //capture their selection
                    ConsoleKey choice = Console.ReadKey(true).Key;

                    //clear the console
                    Console.Clear();
                    //switch
                    switch (choice)
                    {
                        case ConsoleKey.A: //Combat
                            #region possible expansion - racial/weapon bonus
                            //Give certain races or characters with a certain weapon or advantage.
                            //if the player race is dark elf, then combat.doattack(player, monster)
                            #endregion
                            Combat.DoBattle(player, monster);

                            //check if the monster is dead
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nPraise Crom! You killed {monster.Name!}\n");
                                Console.ResetColor();
                                reload = true;
                                score++;
                                //Possible Expansion: Comabt rewards. Money, Weapons, etc
                            }

                            break;
                        case ConsoleKey.R: //TODO Run Away
                            Console.WriteLine("Fall back! Regroup and heal!");
                            //Attack of opportunity
                            Combat.DoAttack(monster, player);
                            reload = true;
                            break;
                        case ConsoleKey.P: //Player
                            Console.WriteLine("Player Info");
                            Console.WriteLine(player);
                            Console.WriteLine("You have defeated " + score + " monsters.");
                            break;
                        case ConsoleKey.M: //Monster
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.Escape:
                        case ConsoleKey.X:
                            Console.WriteLine("Would you so meagerly sever that thread?");
                            lose = true;
                            break;

                        default:
                            Console.WriteLine("Your actions cannot be divined.");
                            break;
                    }//end switch

                    //TODO Check player life. If they're dead, game over.
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Crom favors valour. Wander in the mists like the Cimmerians!\a");
                        lose = true;
                    }
                } while (!reload && !lose);
                //Have loop keep going while not "reload AND lose"
                #endregion


            } while (!lose);
            //Have loop keep going while not "lose"
            //Output the final score.
            Console.WriteLine("You have defeated " + score + $" monster{(score == 1? "." : "s.")}");
        }//end Main()

        //TODO GetRoom() returns string (reference magic 8 ball lab)
        private static string GetRoom()
        {
            //create a string[]
            string[] rooms = {
                "You stand before the threshold of the decayed temple of enlightenment.\n" +
                "The forest spat you out after trial and tribulation, and now you are here\n" +
                "to kill the hell spawn lich and abscond with his fortunes!",
                "The Common Hall: a nexus between lecture, laboratory, and a chamber devoted to\n" +
                "the worship of Mitra. It is wide, and scattered about are the remains of\n" +
                "tattered rugs and banners, overturned bookcases and other furniture.",
                "The Lecture Hall: A half colosseum once portraying the battle of the minds.\n" +
                " There could be treasure, or something that may help you here.",
                "The Laboratory: Men of science and philosophy put their long-winded notions\n" +
                " of life and death to the test here.", 
                "The Shrine of Mitra: But this is no shrine of Mitra; The twisted machinations\n" +
                " of the cursed undead turned this into a place of worshipping Set!",
                "The Chamber of the Lich: The fabled treasure and the cursed Lich stands before\n" +
                " you in a hidden chamber behind the statue. Slay him, and rid Nemedia of his\n" +
                " madness."
            };
            //rng
            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            //return a room using the rng
            return rooms[index];

            //return rooms[new Random().Next(rooms.Length)];

        }//end GetRoom()

        private static Monster GetMonster()
        {
            Monster m1 = new("Ape Demon", 50, 40, 20, 1, 8, "A hellion from the planes of madness!");
            Monster m2 = new("Hostile Barbarian", 40, 50, 30, 1, 8, "A jibbering wildman from the hills");
            Monster m3 = new("Cultist of Set", 70, 30, 10, 1, 8, "A wicked priest of the Snake God");
            Monster m4 = new("Ghoul", 15, 25, 60, 1, 8, "An undead wretch");
            //create 4 monster subtypes. change monster array.
            Monster[] monsters =
            {
                m1,m1,
                m2,
                m3,
                m4,m4,m4,m4,
            };

            return monsters[new Random().Next(monsters.Length)];
        }

    }//end Program
}//end namespace