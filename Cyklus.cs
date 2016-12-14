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
            while (pocet < 3) //Cyklus pro opakovní
            {
                Console.Write("Zadej číslo: ");
                int cislo = Convert.ToInt32(Console.ReadLine());
                if (cislo > 0)
                {
                    Console.WriteLine("\t" + cislo);
                    pocet++;
                }
                else
                {
                    Console.WriteLine("\tTohle není kladné číslo!");
                }
            }
            Console.ReadKey();
        }
    }
}
