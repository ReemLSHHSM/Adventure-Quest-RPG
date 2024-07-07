
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
        public bool isAvailable=false;
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
        public bool DiscoverLocation() {

            if (availableLocations.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine($"========================================");
                Console.WriteLine("You have discovered all locations.");
                Console.WriteLine($"========================================");
                Console.ForegroundColor = ConsoleColor.Blue;
               // isAvailable = false;
                return false;
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
           // isAvailable = true;
            player.Location = location;
            return true;
        }


        private void EncounterMonster()
        {
            Monster monster = monsters[random.Next(monsters.Count)];

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"========================================");
            Console.WriteLine($"You encounter a {monster.Name}!");
            Console.WriteLine($"========================================");
            Console.ForegroundColor = ConsoleColor.Blue;

           

            Console.WriteLine("Starting battle...");

            BattleSystem.StartBattle(player, monster);

            if (player.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"========================================");
                Console.WriteLine("Game over! You have been defeated.");
                Console.WriteLine($"========================================");
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("Would you like to play again? (y/n)");

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

