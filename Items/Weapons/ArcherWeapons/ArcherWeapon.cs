using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class ArcherWeapon : Weapon
    {
        public ArcherWeapon(int money, int endurance, int fragility, int damage) : base(money, endurance, fragility, damage)
        {

        }
    }
}