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
            //vedle sebe oddělené hvězdičkou
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(8 * i);
                if (i != 10)
                {
                    Console.Write(" * ");
                }
            }
            Console.WriteLine();
            //pod sebou, s výpočtem
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x 8 = " + i * 8);
            }
            //od 20 do -20 sestupně
            for (int i = 20; i >= -20; i--)
            {
                Console.WriteLine(i);
            }
            //od proměnné cislo 5krát odečtěte číslo 8
            int cislo = 100;
            for (int i = 1; i <= 5; i++)
            {
                cislo = cislo - 8;
                Console.WriteLine(cislo);
            }
 
            Console.ReadKey();
        }
    }
}
