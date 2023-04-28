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
            Console.WriteLine("You cleft your way through the Forest of Thorns Without Honor, and into the halls of the decrepit college from which the radiant curse spread. The lich lies ahead. Do not dare return home without his skull.");

            #endregion

            //TODO - Variable to keep score

            //Weapon object creation

            //Player object creation

            //Main Game Loop
            bool lose = false;
            do
            {
                //Generate a room
                Console.WriteLine(GetRoom());
                //TODO - Generate a monster

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
                        case ConsoleKey.A: //TODO Combat
                            break;
                        case ConsoleKey.R: //TODO Run Away
                            Console.WriteLine("Fall back!");
                            reload = true;
                            break;
                        case ConsoleKey.P: //TODO Player
                            break;
                        case ConsoleKey.M: //TODO Monster
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
                } while (!reload && !lose);
                //Have loop keep going while not "reload AND lose"
                #endregion


            } while (!lose);
            //Have loop keep going while not "lose"
            //TODO Output the final score.
        }//end Main()

        //TODO GetRoom() returns string (reference magic 8 ball lab)
        private static string GetRoom()
        {
            //create a string[]
            string[] rooms = {
                "Room 1",
                "Room 2",
                "Room 3",
                "Room 4", 
                "Room 5",
                "Room 6"
            };
            //rng
            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            //return a room using the rng
            return rooms[index];

            //return rooms[new Random().Next(rooms.Length)];

        }//end GetRoom()


    }//end Program
}//end namespace