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
            int pocet = 0;
            ostrava:
            if (pocet < 3)
            {
                Console.Write("Zadej číslo: ");
                int cislo = Convert.ToInt32(Console.ReadLine());
                if (cislo > 0)
                {
                    Console.WriteLine("\t" + cislo);
                    pocet = pocet + 1;
                }
                else
                {
                    Console.WriteLine("\tTohle není kladné číslo!");
                }
                goto ostrava;
            }
            Console.ReadKey();
        }
    }
}
