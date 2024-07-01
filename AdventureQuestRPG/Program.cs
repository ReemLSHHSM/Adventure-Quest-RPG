using System.Diagnostics.CodeAnalysis;

namespace AdventureQuestRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            BattleSystem battleSystem = new BattleSystem();
            Skullton skullton = new Skullton();
            Console.WriteLine(battleSystem.Attack(skullton,player));
            

        }
    }
}
