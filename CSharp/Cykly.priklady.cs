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
            //malá násobilka 8 vedle sebe
            for (int i = 1; i <=10; i++)
            {
                Console.Write(i * 8 + " ");
            }
            //Konec
            Console.WriteLine("\n");
            //malá násobilka 8 pod sebe včetně výpočtu
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x 8 = " + i * 8);
            }
            //Konec
            Console.WriteLine();
            //vypiš čísla od 20 do -20 sestupně
            for (int i = 20; i >= -20; i--)
            {
                Console.Write(i + " ");
            }
            //Konec
            Console.WriteLine("\n");
            //od proměnné zadané uživatelem odečtěte 5krát číslo 8
            Console.Write("Zadej číslo: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 5; i++)
            {
                x = x - 8;
                Console.WriteLine(x);
            }
            //Konec
            Console.WriteLine();
            //vypiš vedle sebe znak % tolikrát, kolikrát zadá uživatel
            Console.Write("Zadej počet: ");
            int pocet = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= pocet; i++)
            {
                Console.Write("% ");
            }
            //Konec
            Console.WriteLine("\n");
            //vypiš pod sebe tolik náhodných čísel, kolik zadá uživatel
            Random Nahoda = new Random();
            Console.Write("Zadej počet: ");
            int Pocet = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Pocet; i++)
            {
                Console.WriteLine(Nahoda.Next(-1000, 1001));
            }
            //Konec
            Console.WriteLine();
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
            //Konec
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
            //Konec
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
