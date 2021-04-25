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
            activeWeapon = new FlexibleStickWithThread();
            activeArmor = new Trousers();
        }

        public override void Change(Item item)
        {
            if (inventory.Contains(item))
            {
                if (item is ArcherArmor)
                {
                    Armor a = activeArmor;
                    inventory.Remove(item);
                    activeArmor = item as Armor;
                    inventory.Add(a);
                }
                else if (item is ArcherWeapon)
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