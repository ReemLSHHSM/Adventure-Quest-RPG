using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    internal class BattleSystem
    {

        public int Attack(dynamic attacker,dynamic target)
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

            Console.WriteLine($"{attacker.Name} damaged {target.Name} by {damage} points {target.Name}'s health is now {target.Health}");

            Console.WriteLine("=======================================");
            return target.Health;
        }
    }
}
