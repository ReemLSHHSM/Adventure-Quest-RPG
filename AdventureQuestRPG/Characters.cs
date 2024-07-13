using AdventureQuestRPG;

namespace AdventureQuestRPG
{

    //player class
    public class Player : IBattleStates
    {

        public Inventory inventory = new Inventory();
        //Properties with default values
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Defense { get; set; } = 30;
        public int AttackPower { get; set; } = 10;
        public int Level { get; set; } = 1;
        public Location Location { get; set; }
        //without these values the output will be the original default values of c#


        //constructor
        public Player(string name, int health = 100, int defense = 30, int attackPower = 10, Location location = Location.Forest,int Level=1)//i put them here so when the object is made it doesnt require that i add arguments
        {
            Name = name;
            Health = health;
            Defense = defense;
            AttackPower = attackPower;
            Location = location;
           this.Level = Level;

        }

        public void addItem(Item item)
        {
            inventory.Add_item(item);



        }

        public void useItem(string name)
        {
            List<Item> options = inventory.return_list();
            

            while (name != "potion" && name != "weapon" && name != "armor")
            {
                Console.WriteLine("Item unavailable!");
                Console.WriteLine("Please try again");
                name = Console.ReadLine();
            }

            bool itemFound = false;

            for (int i = options.Count - 1; i >= 0; i--)
            {
                while (options[i].Name != name)
                {
                    Console.WriteLine("You don't have this item");
                    Console.WriteLine("What item do you want to use?");
                    name = Console.ReadLine();
                }


                    if (options[i].Name == name)
                    {
                        itemFound = true;

                        switch (options[i].Name)
                        {
                            case "potion":
                                this.Health += 20;
                                Console.WriteLine($"Your health now is {this.Health}");
                                options.Remove(options[i]);
                                break;
                            case "weapon":
                                this.AttackPower += 30;
                                Console.WriteLine($"Your Attack Power now is {this.AttackPower}");
                                options.Remove(options[i]);
                                break;
                            case "armor":
                                this.Defense += 20;
                                Console.WriteLine($"Your defense now is {this.Defense}");
                                options.Remove(options[i]);
                                break;
                            default:
                                Console.WriteLine("Item not found");
                             
                                break;
                        }
                    }
                }
            

            //if (!itemFound)
            //{
            //    while (!itemFound)
            //    {
            //        Console.WriteLine("You don't have this item");
            //        Console.WriteLine("What item do you want to use?");
            //        name = Console.ReadLine();

            //    }

            //}
        }


    }

    public abstract class Monster : IBattleStates
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

        public Monster(string name, int health, int attackPower, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }

        public abstract void Attack(Player player);
    }

    public class Skullton : Monster
    {
        public Skullton(string name = "Skullton", int health = 90, int attackPower = 10, int defense = 10)
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {
            BattleSystem.Attack(this, player);
        }
    }

    public class Zombie : Monster
    {
        public Zombie(string name = "Zombie", int health = 70, int attackPower = 10, int defense = 6)//70,10,6
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {
            BattleSystem.Attack(this, player);
        }
    }

    public class Goblin : Monster
    {
        public Goblin(string name = "Goblin", int health = 80, int attackPower = 15, int defense = 5)//80,15,5
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {
            BattleSystem.Attack(this, player);
        }


    }

    public class Dragon : Monster
    {
        public Dragon(string name = "Dragon", int health = 200, int attackPower = 30, int defense = 20)//200,30,20
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {
            BattleSystem.Attack(this, player);
        }
    }

    public class BossMonster : Monster
    {
        public BossMonster(string name = "Boss Monster", int health = 300, int attackPower = 40, int defense = 25)//300,40,25
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {
            BattleSystem.Attack(this, player);
        }
    }

}