using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Archer : Hero
    {


        public Archer() : base(400, 150)
        {
            ActiveWeapon = new FlexibleStickWithThread();
            ActiveArmor = new Trousers();
        }

        public override void Change(Item item)
        {
            if (Inventory.Contains(item))
            {
                if (item is ArcherArmor)
                {
                    Armor a = ActiveArmor;
                    Inventory.Remove(item);
                    ActiveArmor = item as Armor;
                    Inventory.Add(a);
                }
                else if (item is ArcherWeapon)
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