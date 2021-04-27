using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class KnightArmor : Armor
    {
        public KnightArmor(int money, int endurance, int fragility, int protection) : base(money, endurance, fragility, protection)
        {

        }
    }
}