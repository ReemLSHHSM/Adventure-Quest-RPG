

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

       
    }
}
