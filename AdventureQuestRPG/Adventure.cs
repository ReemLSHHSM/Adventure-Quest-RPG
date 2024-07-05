
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
                
                Console.WriteLine("Choose an action(number):\n 1- Discover a new location \n 2- Attack a monster \n 3- End the game");

                string action = Console.ReadLine().ToLower();

                switch (action)
                {
                    case "3":
                        Console.WriteLine("Ending the game. Goodbye!");
                        break;
                    case "2":
                        EncounterMonster();
                        break;
                    case "1":
                        DiscoverLocation();
                        break;
                    default:
                        Console.WriteLine("Invalid action. Please try again.");
                        break;
                }

            }

        }

        private void DisplayPlayerInfo(Player palyer)
        {
            Console.WriteLine($"You are now in the {player.Location}");
        }
        private void DiscoverLocation() {

            if (availableLocations.Count == 0)
            {
                Console.WriteLine("You have discovered all locations.");
                return;
            }

            int randomIndex = random.Next(availableLocations.Count);
            Location location = availableLocations[randomIndex];
            availableLocations.RemoveAt(randomIndex);
            discoveredLocations.Add(location);

            Console.WriteLine($"You have discovered a new location: {location}!");
            player.Location = location;

        }


        private void EncounterMonster()
        {
            Monster monster = monsters[random.Next(monsters.Count)];
            Console.WriteLine($"You encounter a {monster.Name}!");

            BattleSystem.StartBattle(player, monster);

            if (player.Health <= 0)
            {
                Console.WriteLine("Game over! You have been defeated.");

                Console.WriteLine("would you like to play again? (y/n)");

                string response = "n";
                while (true)
                {
                    response = Console.ReadLine().ToLower();

                    if (response != "n" && response != "y")
                    {
                        Console.WriteLine("Invalid input, try again:");
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
