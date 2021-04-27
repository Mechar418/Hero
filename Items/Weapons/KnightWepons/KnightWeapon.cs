using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class KnightWeapon : Weapon
    {
        public KnightWeapon(int money, int endurance, int fragility, int damage) : base(money, endurance, fragility, damage)
        {

        }
    }
}