using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public abstract class Item
    {

        public virtual string Name { get; set; }
        public virtual string Discreption { get; set; }

        public Item(string Name,string Discreption)
        {
            this.Name = Name;
            this.Discreption = Discreption;
        }


    } 
}
