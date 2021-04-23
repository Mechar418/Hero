using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class ArcherArmor : Armor
    {
        public ArcherArmor(int Money, int Endurance, int Fragility, int Protection) : base(Money, Endurance, Fragility, Protection)
        {

        }
    }
}