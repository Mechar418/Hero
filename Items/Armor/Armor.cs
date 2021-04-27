using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Armor : Item
    {
        public int Protection { get; private set; }
        public Armor(int money, int endurance, int fragility, int protection) : base(money, endurance, fragility)
        {
            Protection = protection;
        }
        virtual public void Use()
        {
            if (!IsBroken)
            {
                Endurance -= Fragility;
                if (Endurance <= 0)
                {
                    IsBroken = true;
                    Endurance = 0;
                }
            }
            else
                Console.WriteLine("Item is broken");
        }
    }
}