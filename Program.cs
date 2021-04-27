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
            Console.WriteLine(b.Inventory);
            while (a.IsAlive && b.IsAlive)
            {
                a.Atack(b);
                Console.WriteLine("Knight health is " + Convert.ToString(b.Health));
                b.Atack(a);
                Console.WriteLine("Archer health is " + Convert.ToString(a.Health));
            }
            if (a.IsAlive)
                Console.WriteLine("Archer won");
            else
                Console.WriteLine("Knight won");
        }
    }
}
