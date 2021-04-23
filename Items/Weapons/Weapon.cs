using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Weapon : Item
    {
        public int damage { get; private set; }
        protected Weapon(int Money, int Endurance, int Fragility, int Damage) : base(Money, Endurance, Fragility)
        {
            damage = Damage;
        }
        virtual override public void Use(Hero hero, int power)
        {
            if (!isBroken)
            {
                endurance -= fragility;
                hero.TakeDamage(damage + power);
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