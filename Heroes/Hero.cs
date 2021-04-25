using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp1
{
    abstract class Hero
    {
        public int health { get; protected set; }
        public int power { get; private set; }
        public bool isAlive {get; protected set;}
        public List<Item> inventory { get; protected set;}
        public Weapon activeWeapon {get; protected set;}
        public Armor activeArmor {get; protected set;}

        public Hero(int Health, int Power)
        {
            health = Health;
            power = Power;
            isAlive = true;
        }
        public void TakeDamage(int Damage)
        {   
            if (activeArmor.endurance > 0)
            {
                if (activeArmor.protection < Damage)
                    health -= Damage - activeArmor.protection;
                activeArmor.Use();
            }
            else
            {
                health -= Damage;
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
            {
                if (activeWeapon.endurance > 0)
                    activeWeapon.Use(hero, power);
            }
            else
                Console.WriteLine("Hero is dead");
        }
        public void TakeItem(Item item)
        {
            inventory.Add(item);
        }
        public void Dispose(Item item)
        {
            inventory.Remove(item);
        }
        public abstract void Change(Item item);
    }
}