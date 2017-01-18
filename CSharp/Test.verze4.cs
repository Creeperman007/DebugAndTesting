using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte cenu zboží: ");
            double cena = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nákup na firmu? (a/n): ");
            string nakup_na_firmu = Console.ReadLine();
            Console.Write("Cena zboží je ");
            if (cena > 999)
            {
                cena = cena - 50;
            }
            if (nakup_na_firmu == "a")
            {
                cena = cena * 0.8;
            }
            Console.WriteLine(cena + " Kč");
            Console.ReadKey();
        }
    }
}
