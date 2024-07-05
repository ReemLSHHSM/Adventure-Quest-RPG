using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdventureQuestRPG
{
    public class BattleSystem
    {

        public static int Attack(IBattleStates attacker,IBattleStates target)
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
            dynamic option = land_thing();
            while (player.Health > 0 && enemy.Health > 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Player's turn:");
                Attack(player, enemy);
                if (enemy.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{enemy.Name} defeated! You win!");
                    if (option != "nothing")
                    {
                        Console.WriteLine($"{enemy.Name} dropped {option.Name} behind");
                    }
                    else
                    {
                        Console.WriteLine($"{enemy.Name} dropped nothing behind");
                    }
                  
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Your hleath is: {player.Health}\nYour defense is: {player.Defense}");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("=======================================");
                    if (option != "nothing")
                    {
                        //call add
                        player.addItem(option);

                    }
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

     
        public static dynamic loot() {

            Random random = new Random();
         Potion potion = new Potion();
        Weapon weapon = new Weapon();
        Armor armor = new Armor();
            List<object> pocket = new List<object>
            {
                potion,
                "nothing",
                weapon,
                "nothing",
                armor,
                "nothing",
                "nothing",

            };

           
           
            dynamic option =pocket[random.Next(pocket.Count())];
            return option;
        }

        public static dynamic land_thing() {

          dynamic  option = loot();

            return option;
        
        }
    }
}
