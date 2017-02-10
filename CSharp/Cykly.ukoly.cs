using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CyklyCviceni
{
    class CyklyCviceni
    {
        static void Main(string[] args)
        {
            //Vypiš znak % vedle sebe tolikrát, kolikrát uživatel zadá
            Console.Write("Zadej počet: ");
            int pocet = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= pocet; i++)
            {
                Console.Write("%");
            }
            //Konec
            Console.WriteLine("\n");
            //Vypiš pod sebe tolik náhodných čísel, kolik uživatel zadá
            Random nahoda = new Random();
            Console.Write("Zadej počet: ");
            int Pocet = Convert.ToInt32(Console.ReadLine());
            int cislo;
            for (int i = 1; i <= Pocet; i++)
            {
                cislo = nahoda.Next(-100, 101); //lze zadat jiný rozsah
                Console.WriteLine(cislo);

                /* lze zapsat také jako
                Console.WriteLine(nahoda.Next(-100, 101);
                */
            }
            //Konec
            Console.WriteLine("\n");
            //Vypiš čísla od -200 do 200, která jsou dělitelná vstupem
            Console.Write("Zadej číslo: ");
            int delitel = Convert.ToInt32(Console.ReadLine());
            for (int i = -200; i <= 200; i++)
            {
                if (i % delitel == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Konec
            Console.ReadKey();
             
        }
    }
}
