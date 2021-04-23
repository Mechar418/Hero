using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class KnightWeapon : Weapon
    {
        public KnightWeapon(int Money, int Endurance, int Fragility, int Damage) : base(Money, Endurance, Fragility, Damage)
        {

        }
    }
}