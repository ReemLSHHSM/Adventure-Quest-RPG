

namespace AdventureQuestRPG
{

    //player class


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
