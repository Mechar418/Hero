using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class ArcherArmor : Armor
    {
        public ArcherArmor(int money, int endurance, int fragility, int protection) : base(money, endurance, fragility, protection)
        {

        }
    }
}