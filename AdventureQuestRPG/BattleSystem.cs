using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class BattleSystem
    {

        public static int Attack(dynamic attacker,dynamic target)
        {

            int damage;
            if (target.Defense > attacker.AttackPower)
            {
                damage = /*target.Defense -*/ attacker.AttackPower;
                target.Health -= damage;
            }
            else
            {
                damage =target.Defense;
                target.Health -= damage;
            }

            if (target.Health < 0)
            {

                target.Health = 0;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{attacker.Name} damaged {target.Name} by {damage} points {target.Name}'s health is now {target.Health}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=======================================");
            return target.Health;
        }

        public static void StartBattle(Player player, Monster enemy)
        {
            while (player.Health > 0 && enemy.Health > 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Player's turn:");
                Attack(player, enemy);
                if (enemy.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{enemy.Name} defeated! You win!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Enemy's turn:");
                enemy.Attack(player);
                if (player.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("K.O");
                    Console.WriteLine("You have been defeated!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }
    }
}
