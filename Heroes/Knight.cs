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

        }

        public override void Change(Item item)
        {
            if (armor.Contains(item))
            {
                if (item is KnightArmor)
                {
                    item a = activeArmor;
                    armor.Remove(item);
                    activeArmor = item;
                    armor.Add(a);
                }
            } if (weapons.Contains(item))
            {
                if (item is KnightWeapon)
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