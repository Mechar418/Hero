using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Weapon : Item
    {
        public int Damage { get; private set; }
        protected Weapon(int money, int endurance, int fragility, int damage) : base(money, endurance, fragility)
        {
            Damage = damage;
        }
        public virtual void Use(Hero hero, int power)
        {
            if (!IsBroken)
            {
                Endurance -= Fragility;
                hero.TakeDamage(Damage + power);
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