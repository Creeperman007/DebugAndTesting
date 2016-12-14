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
            ostrava: //označení místa pro navrácení
            if (pocet < 3) //kontrola, zda číslo nedosáhlo hodnoty 3
            {
                Console.Write("Zadej číslo: ");
                int cislo = Convert.ToInt32(Console.ReadLine());
                if (cislo > 0) //kontrola, zda je číslo kladné
                {
                    Console.WriteLine("\t" + cislo);
                    pocet = pocet + 1;
                }
                else
                {
                    Console.WriteLine("\tTohle není kladné číslo!");
                }
                goto ostrava; //návrat na začátek
            }
            Console.ReadKey();
        }
    }
}
