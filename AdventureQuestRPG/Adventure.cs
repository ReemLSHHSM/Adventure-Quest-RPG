
namespace AdventureQuestRPG
{

    public enum Location
    {
        Forest,
        Cave,
        Village,
        Castle
    }

    public class Adventure
    {
        private Player player;
        private List<Monster> monsters;
        private Random random;
        private List<Location> availableLocations;
        private List<Location> discoveredLocations;

        public Adventure()
        {
            
            InitializePlayer();
            monsters = new List<Monster>
            {
                new Goblin(),
                new Zombie(),
                new Skullton(),
                new Dragon(),
                new BossMonster()
            };

            random = new Random();

            availableLocations = new List<Location>
            {
                Location.Cave,
                Location.Village,
                Location.Castle
            };
            discoveredLocations = new List<Location>();
        }

        private void InitializePlayer()
        {
            string playerName = getPlayerName();
            player = new Player(playerName);
            Console.WriteLine($"Welcome, {player.Name}!");
        }
        static string getPlayerName()
        {

            Console.WriteLine("Enter your name:");
            string name;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                name = Console.ReadLine();
                bool test_name = Int32.TryParse(name, out int num_name);
                if (!String.IsNullOrEmpty(name) && test_name == false)
                {
                    return name;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your name should neither be empty nor a number!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }
        }

        public void Start()
        {

            while (true)
            {
                DisplayPlayerInfo(player);

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine($"========================================");
                Console.WriteLine("Choose an action(number):\n 1- Discover a new location \n 2- Attack a monster \n 3- End the game");
                Console.WriteLine($"========================================");

                Console.ForegroundColor = ConsoleColor.Blue;

                string action = Console.ReadLine().ToLower();

                switch (action)
                {
                    case "3":
                        Console.WriteLine("Ending the game. Goodbye!");
                        Environment.Exit(0);
                        break;
                    case "2":
                        EncounterMonster();
                        break;
                    case "1":
                        DiscoverLocation();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid action. Please try again.");
                        Console.ForegroundColor = ConsoleColor.Blue;

                        break;
                }

            }

        }

        private void DisplayPlayerInfo(Player palyer)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"========================================");
            Console.WriteLine($"You are now in the {player.Location}");
            Console.WriteLine($"========================================");
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        private void DiscoverLocation() {

            if (availableLocations.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine($"========================================");
                Console.WriteLine("You have discovered all locations.");
                Console.WriteLine($"========================================");
                Console.ForegroundColor = ConsoleColor.Blue;

                return;
            }

            int randomIndex = random.Next(availableLocations.Count);
            Location location = availableLocations[randomIndex];
            availableLocations.RemoveAt(randomIndex);
            discoveredLocations.Add(location);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"========================================");
            Console.WriteLine($"You have discovered a new location: {location}!");
            Console.WriteLine($"========================================");
            Console.ForegroundColor = ConsoleColor.Blue;

            player.Location = location;

        }


        private void EncounterMonster()
        {
            Monster monster = monsters[random.Next(monsters.Count)];
           // Inventory inventory = new Inventory();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"========================================");
            Console.WriteLine($"You encounter a {monster.Name}!");
            //use item
            //Inventory inventory = new Inventory();
            //Console.WriteLine("Your statuse:");
            //Console.WriteLine($"Health: {player.Health}\tDefense: {player.Defense} \tAttack_Power: {player.AttackPower}");
            //Console.WriteLine("your length: " + inventory.view() + ".");
            //bool result= inventory.Display();
            //if (result) {
            //    Console.WriteLine("What item would you like to use?");
            //    string item = Console.ReadLine();
            //    player.useItem(item);
               
                
            //}
      

            Console.WriteLine($"========================================");
            Console.ForegroundColor = ConsoleColor.Blue;


            BattleSystem.StartBattle(player, monster);

            if (player.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"========================================");
                Console.WriteLine("Game over! You have been defeated.");
                Console.WriteLine($"========================================");
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("would you like to play again? (y/n)");

                string response = "n";
                while (true)
                {
                    response = Console.ReadLine().ToLower();

                    if (response != "n" && response != "y")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"========================================");
                        Console.WriteLine("Invalid input, try again:");
                        Console.WriteLine($"========================================");
                        Console.ForegroundColor = ConsoleColor.Blue;

                    }
                    else
                        break;


                }
                if (response == "y")
                {
                    Adventure adventure = new Adventure();
                    adventure.Start();
                }

                Environment.Exit(0);
            }
        }
    }
}
