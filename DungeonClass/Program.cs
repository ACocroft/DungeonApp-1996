using DungeonLibrary;
using System.Numerics;

namespace DungeonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction
            //System.Windows.Extensions (NuGet package)
            Console.Title = "Conan the Cimmerian: The Harrowing Halls of Nemedia ";
            Console.WriteLine("                                  ╔═╗┌─┐┌┐┌┌─┐┌┐┌                                 \r\n                                  ║  │ ││││├─┤│││                                 \r\n                                  ╚═╝└─┘┘└┘┴ ┴┘└┘                                 \r\n╔╦╗┬ ┬┌─┐  ╦ ╦┌─┐┬─┐┬─┐┌─┐┬ ┬┬┌┐┌┌─┐  ┬ ┬┌─┐┬  ┬  ┌─┐  ┌─┐┌─┐  ┌┐┌┌─┐┌┬┐┌─┐┌┬┐┬┌─┐\r\n ║ ├─┤├┤   ╠═╣├─┤├┬┘├┬┘│ │││││││││ ┬  ├─┤├─┤│  │  └─┐  │ │├┤   │││├┤ │││├┤  │││├─┤\r\n ╩ ┴ ┴└─┘  ╩ ╩┴ ┴┴└─┴└─└─┘└┴┘┴┘└┘└─┘  ┴ ┴┴ ┴┴─┘┴─┘└─┘  └─┘└    ┘└┘└─┘┴ ┴└─┘─┴┘┴┴ ┴\n " +
                              "\n                 \r\n                         .'       `.\r\n                        :      ^v^  :\r\n                        :           :\r\n                        '           '\r\n         |~        www   `.       .'\r\n        /.\\       /#^^\\_   `-/\\--'\r\n       /#  \\     /#%    \\   /# \\\r\n      /#%   \\   /#%______\\ /#%__\\\r\n     /#%     \\   |= I I ||  |- |\r\n     ~~|~~~|~~   |_=_-__|'  |[]|\r\n       |[] |_______\\__|/_ _ |= |`.\r\n^V^    |-  /= __   __    /-\\|= | :;\r\n       |= /- /\\/  /\\/   /=- \\.-' :;\r\n       | /_.=========._/_.-._\\  .:'\r\n       |= |-.'.- .'.- |  /|\\ |.:'\r\n       \\  |=|:|= |:| =| |~|~||'|\r\n        |~|-|:| -|:|  |-|~|~||=|      ^V^\r\n        |=|=|:|- |:|- | |~|~|| |\r\n        | |-_~__=_~__=|_^^^^^|/___\r\n        |-(=-=-=-=-=-(|=====/=_-=/\\\r\n        | |=_-= _=- _=| -_=/=_-_/__\\ \r\n        | |- _ =_-  _-|=_- |]#| I II\r\n        |=|_/ \\_-_= - |- = |]#| I II\r\n        | /  _/ \\. -_=| =__|]!!!I_II!!\r\n       _|/-'/  ` \\_/ \\|/' _ ^^^^`.==_^.\r\n     _/  _/`-./`-; `-.\\_ / \\_'\\`. `. ===`.\r\n    / .-'  __/_   `.   _/.' .-' `-. ; ====;\\\r\n   /.   `./    \\ `. \\ / -  /  .-'.' ====='  >\r\n  /  \\  /  .-' `--.  / .' /  `-.' ======.' /\n" +
                "You cleft your way through the Forest of Thorns Without Honor, and into the halls of the decrepit temple from which evil ravages Nemedia. The foul snake lich lies ahead. Return richer than ever, or die a wastrel.");
            Console.WriteLine();

            #endregion

            //Variable to keep score
            //Potential expansion, use "money" instead of a score to let user buy potions or whatever.
            int treasure = 0;
            int beefBone = 0;
            Random rand = new Random();
            int score = 0;

            #region Weapon Choice

            Weapon wep1 = new("Broadword", 1, 8, 10, false, WeaponType.Broadsword);
            Weapon wep2 = new("Bow", 2, 10, 15, true, WeaponType.Bow);
            Weapon wep3 = new("Axe", 3, 12, 5, true, WeaponType.Axe);
            Weapon wep4 = new("Scimitar", 1, 12, 15, false, WeaponType.Scimitar);
            Weapon wep5 = new("Fists", 1, 4, 40, false, WeaponType.Fists);

            bool wepEquipped = false;
            Weapon equippedWeapon = new();
            do
            {
                Console.WriteLine($"The tool with which you shall crush your enemies and" +
                                  $" see them driven before you!\n" +
                                  $"1) {wep1.WeaponType}\n" +
                                  $"-= An all-arounder =-\n" +
                                  $"            _\r\n _         | |\r\n| | _______| |---------------------------------------------\\\r\n|:-)_______|==[]============================================>\r\n|_|        | |---------------------------------------------/\r\n           |_|\n" +
                                  $"2) {wep2.WeaponType}\n" +
                                  $"-= Pick off enemies with ease =-\n" +
                                  $"   (\r\n    \\\r\n     )\r\n##-------->        \r\n     )\r\n    /\r\n   (\n" +
                                  $"3) {wep3.WeaponType}\n" +
                                  $"-= A brutal but clumsy tool =-\n" +
                                  $" _________________.---.______\r\n(_(______________(_o o_(____()\r\n        mrf  .___.'. .'.___.\r\n             \\ o    Y    o /\r\n              \\ \\__   __/ /\r\n               '.__'-'__.'\r\n                   '''\n" +
                                  $"4) {wep4.WeaponType}\n" +
                                  $"-= Crafty, and requiring dexterity =-\n" +
                                  $"   _,---,_\r\n /'_______`\\\r\n(/'       `\\|___________----------\"\"\"\"\"\"\"------,\r\n \\#########||______                          /'\r\n  ^^^^^^^^^||      \"\"\"\"\"\"-----_____        /'\r\n            \\                      \"\"\"--_/'\n" +
                                  $"5) {wep5.WeaponType}\n" +
                                  $" -= When all else fails... =-\n" +
                                  $"  .----.-----.-----.-----.\r\n /      \\     \\     \\     \\\r\n|  \\/    |     |   __L_____L__\r\n|   |    |     |  (           \\\r\n|    \\___/    /    \\______/    |\r\n|        \\___/\\___/\\___/       |\r\n \\      \\     /               /\r\n  |                        __/\r\n   \\_                   __/\r\n    |        |         |\r\n    |                  |\r\n    |                  |");
                char userChoice = (Console.ReadKey().KeyChar);
                Console.WriteLine();
                switch (userChoice)
                {
                    case '1':
                        equippedWeapon = wep1;
                        wepEquipped = true;
                        break;
                    case '2':
                        equippedWeapon = wep2;
                        wepEquipped = true;
                        break;
                    case '3':
                        equippedWeapon = wep3;
                        wepEquipped = true;
                        break;
                    case '4':
                        equippedWeapon = wep4;
                        wepEquipped = true;
                        break;
                    case '5':
                        equippedWeapon = wep5;
                        wepEquipped = true;
                        break;
                    default:
                        Console.WriteLine("Your actions cannot be divined.");
                        break;
                }
            } while (!wepEquipped);
            #endregion

            // WeaponType[] weapons = Enum.GetValues<WeaponType>();
            //.GetValues(typeof(WeaponType))
            // foreach (WeaponType item in weapons)
            {
                //     Console.WriteLine($"{(int)item + 1} - {item}");
            }
            // int userChoice = Convert.ToInt32(Console.ReadLine());


            // WeaponType equippedWeapon = (WeaponType)(userChoice - 1);
            //Potential expansion: Show user list of weapons and let them pick one, or assign one at random.

            //Player object creation
            //Recommended Expansion - Player Customization. Pick a name and race.
            #region PlayerRace
                                    //hitchance, block, maxlife
            Player r1 = new("Cimmerian", 60, 40, 70, RaceEnums.Cimmerian, equippedWeapon);
            Player r2 = new("Shemite", 70, 35, 60, RaceEnums.Shemite, equippedWeapon);
            Player r3 = new("Kushite", 50, 65, 55, RaceEnums.Kushite, equippedWeapon);
            Player r4 = new("Stygian", 80, 25, 40, RaceEnums.Stygian, equippedWeapon);
            Player r5 = new("Himelian", 50, 40, 100, RaceEnums.Himelian, equippedWeapon);


            bool raceChosen = false;
            Player selectedRace = new();
            do
            {
                Console.WriteLine($"What is your race? (number only) \n" +
                                  $"--------------------\n\n" +
                                  $"1) {r1}\n" +
                                  $"2) {r2}\n" +
                                  $"3) {r3}\n" +
                                  $"4) {r4}\n" +
                                  $"5) {r5}\n");
                                  
                char userChoice = (Console.ReadKey().KeyChar);
                Console.WriteLine();
                switch (userChoice)
                {
                    case '1':
                        selectedRace =  r1;
                        raceChosen = true;
                        break;
                    case '2':
                        selectedRace = r2;
                        raceChosen = true;
                        break;
                    case '3':
                        selectedRace =  r3;
                        raceChosen = true;
                        break;
                    case '4':
                        selectedRace =  r4;
                        raceChosen = true;
                        break;
                    case '5':
                        selectedRace =  r5;
                        raceChosen = true;
                        break;
                    default:
                        Console.WriteLine("Your actions cannot be divined.");
                        break;
                }
            } while (!raceChosen);
            #endregion

            #region PlayerName
            Console.WriteLine("What is your name?");

            selectedRace.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(selectedRace);

            #endregion

            //Player player = new("1", 1, 1, 1, RaceEnums.Cimmerian, equippedWeapon);

            //Customization Menu Loop
            bool lose = false;
            do
            {
                           //Generate a room
                Console.WriteLine(GetRoom());
                Monster monster = GetMonster();
                Console.WriteLine("In this room, a " +monster.Name + " skulks about!");
                bool reload = false;

                #region Main Menu Loop
                //Encounter/Menu Loop
                do
                {
                    //print the menu
                    Console.WriteLine("\nPlease choose an action: \n" +
                        "A) Strike\n" +
                        "R) Retreat\n" +
                        "H) Heal\n" +
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
                            Combat.DoBattle(selectedRace, monster);

                            //check if the monster is dead
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nPraise Crom! You killed {monster.Name!}\n");
                                Console.ResetColor();
                                reload = true;
                                score++;
                                int goldToAdd = rand.Next(1, 51);
                                treasure += goldToAdd;
                                int beefToAdd = rand.Next(0, 2);
                                beefBone += beefToAdd;
                                //Possible Expansion: Comabt rewards. Money, Weapons, etc
                            }

                            break;
                        case ConsoleKey.R: //TODO Run Away
                            Console.WriteLine("Fall back, but beware: The devil you know is better than the one you don't!");
                            //Attack of opportunity
                            Combat.DoAttack(monster, selectedRace);
                            reload = true;
                            break;
                        case ConsoleKey.P: //Player
                            Console.WriteLine("Player Info");
                            Console.WriteLine(selectedRace);
                            Console.WriteLine("You have defeated " + score + " monster(s), carrying " + beefBone + " beef bone(s), and plundered " + treasure + " gold!");
                            break;
                        case ConsoleKey.M: //Monster
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);
                            break;
                        case ConsoleKey.H:
                            Console.WriteLine("Healed!");
                            Console.WriteLine(beefBone);
                            if (beefBone >= 1)
                            {
                                beefBone -= 1;
                                selectedRace.Life = selectedRace.MaxLife;
                            }
                            break;
                        //case ConsoleKey.W:
                        //    Console.WriteLine("Look for weapon");
                        //    Console.WriteLine(discoverWeapon);
                        //    break;
                        case ConsoleKey.Escape:
                        case ConsoleKey.X:
                            Console.WriteLine("You would so meagerly sever that thread?");
                            lose = true;
                            break;

                        default:
                            Console.WriteLine("Your actions cannot be divined.");
                            break;
                    }//end switch

                    //TODO Check player life. If they're dead, game over.
                    if (selectedRace.Life <= 0)
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
            ApeDemon m1 = new("Ape Demon", 50, 40, 20, 8, 1, "A flying hellion from the planes of madness! \n" +
                "          ^                     ^\r\n         / \\       .\"`\".       / \\\r\n        / /\\\\  .-./ _=_ \\.-.  /   \\\r\n       / /  \\\\{  (,(oYo),) }}/ / \\ \\\r\n      / /    \\{{ |   \"   |} }/    \\ \\\r\n     / /      { { \\(---)/  }}      \\ \\\r\n              {{  }'-=-'{ } }\r\n              { { }._:_.{  }}\r\n              {{  } -:- { } }\r\n              {_{ }`===`{  _}\r\n             ((((\\)     (/)))) \n", true);
            Barbarian m2 = new("Hostile Barbarian", 30, 15, 30, 8, 1, "A jibbering wildman from the hills! \n" +
                "               /\\_[]_/\\\r\n              |] _||_ [|\r\n       ___     \\/ || \\/\r\n      /___\\       ||\r\n     (|0 0|)      ||\r\n   __/{\\U/}\\_ ___/vvv\r\n  / \\  {~}   / _|_P|\r\n  | /\\  ~   /_/   []\r\n  |_| (____)        \r\n  \\_]/______\\        \r\n     _\\_||_/_           \r\n    (_,_||_,_)\n", false);
            SetCultist m3 = new("Cultist of Set", 35, 20, 10, 8, 1, "A wicked priest of the Snake God \n" +
                "                      @@@@@@@                      \r\n                    @@@@@@@@@&                    \r\n                    @@@@@@@@@@&                   \r\n                   *@@@@@@@@@@@&                  \r\n                   @@@@@@@@@                      \r\n                     @@@@@@@@@@@@@@@              \r\n               @@@@@@@@@@@@@@@@@@@@@@             \r\n                /@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#   \r\n                @@@@@@@@@@@@@@@@@ @@@@@@@@@@@@@@@,\r\n                @@@@@@@@@@@@@@@@@   @@@@@@@@@@@@@@\r\n @             ,@@@&@@@@@@@@@@@@  /@@@@@@@@@@@@@@%\r\n%@@@           @@@@%@@@@@@@@@@@/ @@@@@@@@@@@@@@@  \r\n @@,          @@@@ @@@@@@@@@@@@@@@@@@@@@@@@@@@@   \r\n @@@         @@@@*@@@@@@@@@@@@@@@@@@@@@@@@@@@@    \r\n  @@@        @@@@ @@@@@@@@@@@@@@@@@@@@@@@@@@      \r\n   @@@@     /@@@ @@@@@@@@@@@@@@@@@@@@@@@@@@       \r\n      @@@@@@@@@  @@@@@@@@@@@@@@@@@@@@@@@@@        \r\n           @@@@  &@@@@@@@@@@@@@@@@@@@@@@          \r\n             @@  /@@@@@@@@@@@@@@@@@@@@@           \r\n                  @@@@@@@@@@@@@@@                 \r\n                  /@@@@@@@%@@@@@,                 \r\n                  .@@@@@@@@@@@@@                  \r\n                   @@@@@@  #@@@@                  \r\n                    @@@@   %@@@@                  \r\n                    @@@@   @@@@@                  \r\n                    @@@@   @@@@@                  \r\n                    @@@@@   @@@@                  \r\n                    @@@@@   @@@@                  \r\n                    /@@@.   &@@                   \r\n                     @@@    @@@*                  \r\n                     #@@.     %@@@                \r\n                    @@@@ \n", false);
            Ghoul m4 = new("Ghoul", 15, 25, 10, 8, 1, "An undead eater of human flesh! \n" +
                "        ----------------------------\r\n        `:.  `::::'':!:``::::'   ::'\r\n        :'*:::.  .:' ! `:.  .:::*`:\r\n       :: HHH::.   ` ! '   .::HHH ::\r\n      ::: `H TH::.  `!'  .::HT H' :::\r\n      ::..  `THHH:`:   :':HHHT'  ..::\r\n      `::      `T: `. .' :T'      ::'\r\n        `:. .   :         :   . .:'\r\n          `::'               `::'\r\n            :'  .`.  .  .'.  `:\r\n            :' ::.       .:: `:\r\n           /:' `:::     :::' `:\\\r\n           | `.  ``     ''  .' |\r\n            \\ :`...........': /\r\n              ` :`.     .': '\r\n               `:  `\"\"\"'  :'         \n", false);
            ApeDemon m5 = new ApeDemon("Dark Ape Demon", 70, 20, 20, 10, 2, "A more feral version of the winged fiend, if such a thing exists! \n" +
                "          ^                     ^\r\n         / \\       .\"`\".       / \\\r\n        / /\\\\  .-./#_=_#\\.-.  /   \\\r\n       / /  \\\\{##(,(oYo),)#}}/ / \\ \\\r\n      / /    \\{{#|   \"   |}#}/    \\ \\\r\n     / /      {#{#\\(---)/##}}      \\ \\\r\n              {{##}'-=-'{#}#}\r\n              {#{#}._:_.{##}}\r\n              {{##} -:- {#}#}\r\n              {_{#}`===`{# _}\r\n             ((((\\)     (/))))\n", false);
            Barbarian m6 = new Barbarian("Ofirian SellSword", 50, 30, 20, 12, 4, "A heavily armored sellsword from the sister country of Ofir! \n" +
                "                   _.--.    .--._\r\n                 .\"  .\"      \".  \".\r\n                ;  .\"    /\\    \".  ;\r\n                ;  '._,-/  \\-,_.`  ;\r\n                \\  ,`  / /\\ \\  `,  /\r\n                 \\/    \\/  \\/    \\/\r\n                 ,=_    \\/\\/    _=,\r\n                 |  \"_   \\/   _\"  |\r\n                 |_   '\"-..-\"'   _|\r\n                 | \"-.        .-\" |\r\n                 |    \"\\    /\"    |\r\n                 |      |  |      |\r\n         ___     |      |  |      |     ___\r\n     _,-\",  \",   '_     |  |     _'   ,\"  ,\"-,_\r\n   _(  \\  \\   \\\"=--\"-.  |  |  .-\"--=\"/   /  /  )_\r\n ,\"  \\  \\  \\   \\      \"-'--'-\"      /   /  /  /  \".\r\n!     \\  \\  \\   \\                  /   /  /  /     !\r\n:      \\  \\  \\   \\                /   /  /  /      TK\n", true);
            SetCultist m7 = new SetCultist("The Lich of Set", 50, 20, 80, 15, 5, "The fell priest" +
                "of Set! \n" +
                "           .                                                      .\r\n        .n                   .                 .                  n.\r\n  .   .dP                  dP                   9b                 9b.    .\r\n 4    qXb         .       dX                     Xb       .        dXp     t\r\ndX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb\r\n9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP\r\n 9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP\r\n  `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'\r\n    `9XXXXXXXXXXXP' `9XX'   DIE    `98v8P'  HUMAN   `XXP' `9XXXXXXXXXXXP'\r\n        ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~\r\n                        )b.  .dbo.dP'`v'`9b.odb.  .dX(\r\n                      ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.\r\n                     dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb\r\n                    dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb\r\n                    9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP\r\n                     `'      9XXXXXX(   )XXXXXXP      `'\r\n                              XXXX X.`v'.X XXXX\r\n                              XP^X'`b   d'`X^XX\r\n                              X. 9  `   '  P )X\r\n                              `b  `       '  d'\r\n                               `             '\n", true);
            Ghoul m8 = new Ghoul("Arch Ghoul", 25, 5, 5, 15, 5, "Watch out! \n" +
                "       ___,---.__          /'|`\\          __,---,___\r\n    ,-'    \\`    `-.____,-'  |  `-.____,-'    //    `-.\r\n  ,'        |           ~'\\     /`~           |        `.\r\n /      ___//              `. ,'          ,  , \\___      \\\r\n|    ,-'   `-.__   _         |        ,    __,-'   `-.    |\r\n|   /          /\\_  `   .    |    ,      _/\\          \\   |\r\n\\  |           \\ \\`-.___ \\   |   / ___,-'/ /           |  /\r\n \\  \\           | `._   `\\\\  |  //'   _,' |           /  /\r\n  `-.\\         /'  _ `---'' , . ``---' _  `\\         /,-'\r\n     ``       /     \\    ,='/ \\`=.    /     \\       ''\r\n             |__   /|\\_,--.,-.--,--._/|\\   __|\r\n             /  `./  \\\\`\\ |  |  | /,//' \\,'  \\\r\n            /   /     ||--+--|--+-/-|     \\   \\\r\n           |   |     /'\\_\\_\\ | /_/_/`\\     |   |\r\n            \\   \\__, \\_     `~'     _/ .__/   /\r\n             `-._,-'   `-._______,-'   `-._,-'\r\n\n", true);

            //create 4 monster subtypes. change monster array.
            Monster[] monsters =
            {
                m1,m1,
                m2,m2,
                m3,m3,m3,m3,
                m4,m4,m4,m4,m4,m4,m4,
                m5,m5,
                m6,m6,m6,
                m7,
                m8,m8
            };

            return monsters[new Random().Next(monsters.Length)];
        }

    }//end Program
}//end namespace