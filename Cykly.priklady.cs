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
            //vypiš čísla z rozhasu zadaný uživatelem, která jsou dělitelná 17
            Console.Write("Zadejte nejnižší číslo: ");
            int dole = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte nejvyšší číslo: ");
            int nahore = Convert.ToInt32(Console.ReadLine());
            for (int i = dole; i <= nahore; i++)
            {
                if (i % 17 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            //vypiš 20 čísel (od -15 do 15) a pod ně vypiš, kolik je sudých a lichých
            Random nahoda = new Random();
            int cislo;
            int sude = 0;
            int liche = 0;
            for (int i = 0; i < 20; i++)
            {
                cislo = nahoda.Next(-15, 16);
                Console.Write(cislo + " ");
                if (cislo == 0)
                {
                
                }
                else if (cislo % 2 == 0)
                {
                    sude++;
                }
                else
                {
                    liche++;
                }
            }
            Console.WriteLine("\nSudé " + sude + "\nLiché: " + liche + "\n");
            //faktoriál zadaného čísla
            Console.Write("Zadejte číslo: ");
            int Cislo = Convert.ToInt32(Console.ReadLine());
            Int64 faktorial = 1;
            for (int i = Cislo; i > 0; i--)
            {
                faktorial = faktorial * i;
            }
            Console.WriteLine("Faktoriál: " + faktorial);
            Console.ReadKey();
        }
    }
}
