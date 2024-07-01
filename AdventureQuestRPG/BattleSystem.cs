using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    internal class BattleSystem
    {

        public int Attack(int target_defence,int enemy_attackpower,int target_health,string target_name,string enemy_name)
        {
            int damage = target_defence - enemy_attackpower;
            target_health-=damage;

            if (target_health< 0) {
            
            target_health = 0;
            }

            Console.WriteLine($"{enemy_name} damaged {target_name} by {damage} points {target_name}'s health is now {target_health}");
            
            Console.WriteLine("=======================================");
            return target_health;
        }
    }
}
