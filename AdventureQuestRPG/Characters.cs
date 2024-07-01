

namespace AdventureQuestRPG
{

    //player class
    public class Player
    {
        //Fields 
        private string name;
        private int health;
        private int defense;
        private int attackpower;
        //fields are a must when creating a constructor

        //constructor
        public Player(string name, int health = 100, int defense = 30, int attackPower = 10)//i put them here so when the object is made it doesnt require that i add arguments
        {
            Name = name;
            Health = health;
            Defense = defense;
            AttackPower = attackPower;

        }


        //Properties with default values
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Defense { get; set; } = 30;
        public int AttackPower { get; set; } = 10;

        //without these values the output will be the original default values of c#
    }

    public abstract class Monster
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
        public Zombie(string name = "Zombie", int health = 70, int attackPower = 10, int defense = 6)
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {
            BattleSystem.Attack(this, player);
        }
    }

    public class Goblin : Monster
    {
        public Goblin(string name = "Goblin", int health = 80, int attackPower = 15, int defense = 5)
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {
            BattleSystem.Attack(this, player);
        }
    }
}
