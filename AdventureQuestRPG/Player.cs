using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    internal class Player
    {
        //Fields 
        private string name;
        private int health;
        private int defense;
        private int attackpower ;
        //fields are a must when creating a constructor

        //constructor
        public Player(string name = "Unknown Hero", int health = 100,int defense=30, int attackPower = 10)//i put them here so when the object is made it doesnt require that i add arguments
        {
            this.name = name;
            this.health = health;
            this.defense = defense;
            this.attackpower = attackPower;

        }




        //Properties with default values
        public string Name { get; set; } = "Unknown Hero";
        public int Health { get; set; } = 100;
        public int Defense { get; set; } = 30;
        public int AttackPower { get; set; } = 10;

        //without these values the output will be the original default values of c#
    }
}
