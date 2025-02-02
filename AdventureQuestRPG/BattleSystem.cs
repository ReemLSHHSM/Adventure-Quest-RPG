﻿

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
            int enemy_health = enemy.Health;
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("Player's turn:");
                Attack(player, enemy);
                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"Player's Level: {player.Level}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{enemy.Name} defeated! You win!");


                    Console.WriteLine("You have gained XP");
                    player.Level++;
                    player.Defense += player.Level * 5;
                    player.AttackPower += player.Level * 5;
                    if (player.AttackPower > 170 ||player.Defense>170) {
                        player.Defense = 170;
                        player.AttackPower = 170;
                    }

                    dynamic option = land_thing();
                    if (option.GetType() != typeof(string))
                    {
                        Console.WriteLine($"{enemy.Name} dropped {option.Name} behind");
                        player.addItem(option);
                    }
                    else
                    {
                        Console.WriteLine($"{enemy.Name} dropped nothing behind");
                    }
                    Console.WriteLine("Your status:");
                    Console.WriteLine($"Health: {player.Health}\tDefense: {player.Defense}\tAttack Power: {player.AttackPower}");

                    bool result = player.inventory.Display();
                    if (result)
                    {
                        Console.WriteLine("What item would you like to use?\n");
                        Console.WriteLine("[1]Potion\t[2]weapon\t[3]armor\n");
                        string item = Console.ReadLine();
                        player.useItem(item);
                    }


                    //Console.ForegroundColor = ConsoleColor.Blue;
                   // Console.WriteLine($"Your health is: {player.Health}\nYour defense is: {player.Defense}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("=======================================");

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
            enemy.Health = enemy_health;
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
