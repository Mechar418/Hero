using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Knight : Hero
    {


        public Knight() : base(500, 100)
        {
            ActiveWeapon = new WoodenSword();
            ActiveArmor = new CultistRobe();
        }

        public override void Change(Item item)
        {
            if (Inventory.Contains(item))
            {
                if (item is KnightArmor)
                {
                    Armor a = ActiveArmor;
                    Inventory.Remove(item);
                    ActiveArmor = item as Armor;
                    Inventory.Add(a);
                }
                else if (item is KnightWeapon)
                {
                    Weapon a = ActiveWeapon;
                    Inventory.Remove(item);
                    ActiveWeapon = item as Weapon;
                    Inventory.Add(a);
                }
            }
            else
            {
                Console.WriteLine("Hero doesnt this item");
            }
        }
    }
}