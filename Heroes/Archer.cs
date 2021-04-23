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

        }

        public override void Change(Item item)
        {
            if (armor.Contains(item))
            {
                if (item is ArcherArmor)
                {
                    item a = activeArmor;
                    armor.Remove(item);
                    activeArmor = item;
                    armor.Add(a);
                }
            } if (weapons.Contains(item))
            {
                if (item is ArcherWeapon)
                {
                    item a = activeWeapon;
                    weapons.Remove(item);
                    activeWeapon = item;
                    weapons.Add(item);
                }
            }
        }
    }
}