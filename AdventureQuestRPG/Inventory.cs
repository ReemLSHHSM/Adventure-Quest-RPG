using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Inventory
    {

        List<Item> Items = new List<Item>();
       
        public void Add_item(Item obj)
        {

            Items.Add(obj);

        }
        int armor_count = 0;
        int potion_count = 0;
        int weapon_count = 0;
        public bool Display()
        {
            if (Items.Count > 0) {
               
                
                dynamic armor = new Armor();
                dynamic potion = new Potion();
                dynamic weapon = new Weapon();
               
                Console.WriteLine("Your inventory: ");
                foreach (Item item in Items)
                {
                    switch (item.Name)
                    {
                        case "potion":
                            potion_count++;
                            break;
                        case "armor":
                            armor_count++;
                            break;
                        case "weapon":
                            weapon_count++;
                            break;
                        
                    }
                    if (potion_count > 0)
                    {
                        Console.WriteLine("Potion" + "(" + potion_count + ")" + " :" + potion.Discreption);
                    }
                    if (weapon_count > 0)
                    {
                        Console.WriteLine("Weapon" + "(" + weapon_count + ")" + " :" + weapon.Discreption);

                    }
                    if (armor_count > 0) { 
                        Console.WriteLine("Armor" + "(" + armor_count + ")" + " :" + armor.Discreption);

                    }

                }
                return true;
            }
    

            else
            {
                Console.WriteLine("Your Inventory is empty");
                return false;
            }
           
        }

        public dynamic return_list()
        {
            dynamic armor = new Armor();
            dynamic potion = new Potion();
            dynamic weapon = new Weapon();
            //Items.Add(armor);///
            //Items.Add(armor);////
            //Items.Add(armor);////
            //Items.Add(potion);///
            return Items;
        }
    }
}
