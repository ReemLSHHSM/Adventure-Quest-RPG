

namespace AdventureQuestRPG
{

    //player class
    public class Player : IBattleStates
    {

        //Properties with default values
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Defense { get; set; } = 30;
        public int AttackPower { get; set; } = 10;
        public Location Location { get; set; }
        //without these values the output will be the original default values of c#


        //constructor
        public Player(string name, int health = 100, int defense = 30, int attackPower = 10, Location location = Location.Forest)//i put them here so when the object is made it doesnt require that i add arguments
        {
            Name = name;
            Health = health;
            Defense = defense;
            AttackPower = attackPower;
            Location = location;
            
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

    public class Dragon : Monster
    {
        public Dragon(string name = "Dragon", int health = 200, int attackPower = 30, int defense = 20)
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {
            BattleSystem.Attack(this, player);
        }
    }

    public class BossMonster : Monster
    {
        public BossMonster(string name = "Boss Monster", int health = 300, int attackPower = 40, int defense = 25)
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {
            BattleSystem.Attack(this, player);
        }
    }
}
