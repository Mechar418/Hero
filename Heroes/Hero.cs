using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp1
{
    abstract class Hero
    {
        public int health { get; protected set; }
        protected int power { get; private set; }
        public bool isAlive {get; protected set;}
        public List<Weapon> weapons { get; protected set;}
        public List<Armor> armor { get; protected set;}
        public Weapon activeWeapon {get; protected set;}
        public Armor activeArmor {get; protected set;}

        protected Hero(int Health, int Power)
        {
            health = Health;
            power = Power;
            Alive = true;
        }
        public void TakeDamage(int Damage)
        {   
            if (activeArmor.endurance > 0)
            {
                if (activeArmor.protection < damage)
                    health -= damage - activeArmor.protection;
                activeArmor.Use();
            }
            else
            {
                health -= damage;
            }
            if (health <= 0)
            {
                isAlive = false;
                health = 0;
            }
        }
        public void Atack(Hero hero)
        {
            if (isAlive)
                if (activeWeapon.endurance > 0)
                    activeWeapon.Use(hero, power);
            else
                1 / 0;
        }
        public void TakeItem(Item item)
        {
            if (item is Weapon)
                weapons.Add(item);
            else if (item is Armor)
                armor.Add(item);
        }
        public void Dispose(Item item)
        {
            armor.Remove(item);
            weapons.Remove(item);
        }
        public abstract void Change(Item item);
    }
}