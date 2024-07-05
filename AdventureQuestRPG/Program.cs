

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

            Adventure adventure = new Adventure();
            adventure.Start();


        }

       

        //This method will randomly choose the monster to fight the player
        static Monster ChooseRandomMonster()
        {
            Random random = new Random();
            int choice = random.Next(0, 3); // 0 1 2

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"========================================");
            switch (choice)
            {
                case 0:
                    Console.WriteLine($"You will be fighting Goblin");
                    Console.WriteLine($"========================================");
                    return new Goblin();
                case 1:
                    Console.WriteLine($"You will be fighting Zombie");
                    Console.WriteLine($"========================================");
                    return new Zombie();
                case 2:
                    Console.WriteLine($"You will be fighting Skullton");
                    Console.WriteLine($"========================================");
                    return new Skullton();
                default:
                    Console.WriteLine($"You will be fighting Goblin");
                    Console.WriteLine($"========================================");
                    return new Goblin(); // Default case
            }
        }
    }
}
