using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp1
{
    abstract class Hero
    {
        public int Health { get; protected set; }
        public int Power { get; private set; }
        public bool IsAlive {get; protected set;}
        public List<Item> Inventory { get; protected set;}
        public Weapon ActiveWeapon {get; protected set;}
        public Armor ActiveArmor {get; protected set;}

        public Hero(int health, int power)
        {
            this.Health = health;
            this.Power = power;
            IsAlive = true;
            Inventory = new List<Item>();
        }
        public void TakeDamage(int damage)
        {   
            if (ActiveArmor.Endurance > 0)
            {
                if (ActiveArmor.Protection < damage)
                    Health -= damage - ActiveArmor.Protection;
                ActiveArmor.Use();
            }
            else
            {
                Health -= damage;
            }
            if (Health <= 0)
            {
                IsAlive = false;
                Health = 0;
            }
        }
        public void Atack(Hero hero)
        {
            if (IsAlive)
            {
                if (ActiveWeapon.Endurance > 0)
                    hero.TakeDamage(Power + ActiveWeapon.Use(this));
            }
            else
                Console.WriteLine("Hero is dead");
        }
        public void TakeItem(Item item)
        {
            Inventory.Add(item);
        }
        public void Dispose(Item item)
        {
            Inventory.Remove(item);
        }
        public abstract void Change(Item item);
    }
}