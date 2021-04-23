using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Armor : Item
    {
        public int protection { get; private set; }
        public Armor(int Money, int Endurance, int Fragility, int Protection) : base(Money, Endurance, Fragility)
        {
            protection = Protection;
        }
    }
}