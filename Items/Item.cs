using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Item
    {
        public int Money { get; protected set; }
        public int Endurance { get; protected set; }
        public int Fragility {get; set;}
        public bool IsBroken {get; protected set;}
        protected Item(int money, int endurance, int fragility)
        {
            Money = money;
            Endurance = endurance;
            Fragility = fragility;
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