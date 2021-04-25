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
            activeWeapon = new WoodenSword();
            activeArmor = new CultistRobe();
        }

        public override void Change(Item item)
        {
            if (inventory.Contains(item))
            {
                if (item is KnightArmor)
                {
                    Armor a = activeArmor;
                    inventory.Remove(item);
                    activeArmor = item as Armor;
                    inventory.Add(a);
                }
                else if (item is KnightWeapon)
                {
                    Weapon a = activeWeapon;
                    inventory.Remove(item);
                    activeWeapon = item as Weapon;
                    inventory.Add(a);
                }
            }
            else
            {
                Console.WriteLine("Hero doesnt this item");
            }
        }
    }
}