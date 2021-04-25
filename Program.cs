using System;
using ConsoleApp1;

namespace Hero
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer a = new Archer();
            Knight b = new Knight();
            b.TakeItem(new SwordAtomicBomb());
            Console.WriteLine(Convert.ToString(b.inventory));
            /*
            while (a.isAlive && b.isAlive)
            {
                a.Atack(b);
                Console.WriteLine("Knight health is " + Convert.ToString(b.health));
                b.Atack(a);
                Console.WriteLine("Archer health is " + Convert.ToString(a.health));
            }
            */
        }
    }
}
