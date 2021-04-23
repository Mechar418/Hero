using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Item
    {
        public int money { get; protected set; }
        public int endurance { get; protected set; }
        public int fragility {get; set;}
        public bool isBroken {get; protected set;}
        protected Item(int Money, int Endurance, int Fragility)
        {
            money = Money;
            endurance = Endurance;
            fragility = Fragility;
        }
        virtual public void Use()
        {
            if (!isBroken)
            {
                endurance -= fragility;
                if (endurance <= 0)
                {
                    isBroken = true;
                    endurance = 0;
                }
            }
            else
                1 / 0;
        }
    }
}