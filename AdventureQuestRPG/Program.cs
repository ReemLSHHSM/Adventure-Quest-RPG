

namespace AdventureQuestRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**********************************************");
            Console.WriteLine("*                                            *");
            Console.WriteLine("*        Welcome to the AdventureQuest       *");
            Console.WriteLine("*            Epic Battle Awaits!             *");
            Console.WriteLine("*                                            *");
            Console.WriteLine("**********************************************");
            Console.WriteLine("Prepare yourself, brave hero, for an adventure like no other.");
            Console.WriteLine("Face formidable foes and emerge victorious!");
            Console.WriteLine("Let the quest begin...");

            string playerName = getPlayerName();

            Player player = new Player(playerName, 100, 20, 10);
            Monster enemy = ChooseRandomMonster();

            BattleSystem.StartBattle(player, enemy);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Adventure complete!");
            Console.ForegroundColor = ConsoleColor.White;

        }

        static string getPlayerName()
        {

            Console.WriteLine("Enter your name:");
            string name;

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                name = Console.ReadLine();

                if (!String.IsNullOrEmpty(name))
                {
                    return name;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your name shouldn't be empty!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }
        }

        //This method will randomly choose the monster to fight the player
        static Monster ChooseRandomMonster()
        {
            Random random = new Random();
            int choice = random.Next(0, 3); // 0 1 2

            switch (choice)
            {
                case 0:
                    return new Goblin();
                case 1:
                    return new Zombie();
                case 2:
                    return new Skullton();
                default:
                    return new Goblin(); // Default case
            }
        }
    }
}
