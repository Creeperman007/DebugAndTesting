using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej 1. číslo: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej 2. číslo: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej číslo operace:\n\t1 - součet\n\t2 - rozdíl\n\t3 - součin\nVybraná operace: ");
            int operace = Convert.ToInt32(Console.ReadLine());

            if (operace == 1)
            {
                int soucet = x1 + x2;
                Console.WriteLine("Součet: " + soucet);
            }
            else if (operace == 2)
            {
                int rozdil = x1 - x2;
                Console.WriteLine("Rozdíl: " + rozdil);
            }
            else if (operace == 3)
            {
                int soucin = x1 * x2;
                Console.WriteLine("Součin: " + soucin);
            }
            Console.ReadKey();
        }
    }
}
