using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CyklyWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Náhodná čísla od 1 do 1000 tak dlouho, dokud vygeneruje číslo dělitelné 17.
             * To bude vypsáno pod čarou*/
            Console.WriteLine("Příklad č. 1");
            //
            Random nahoda = new Random();
            int cislo = nahoda.Next(0, 1001);
            while (cislo % 17 != 0)
            {
                Console.Write(cislo + " ");
                cislo = nahoda.Next(0, 1001);
            }
            Console.WriteLine("\n----------\n" + cislo);
            Console.ReadKey();
            //
            Console.WriteLine("\nPříklad č. 2");
            //
            /*Vypisuj znaky z klávesnice, dokud uživatel nenapíše znak * */
            char znak;
            do
            {
                Console.Write("Zadej znak: ");
                znak = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(znak);
            } while (znak != '*');
            Console.ReadKey();
            /*Dělte celočíselné číslo 2 tak dlouho, dokud nedojtete k nule*/
            //
            Console.WriteLine("\nPříklad č. 3");
            //
            Console.Write("Zadej kladné číslo: ");
            int cis = Convert.ToInt32(Console.ReadLine());
            int delitel = 2;
            Console.Write(cis);
            do
            {
                cis = cis / delitel;
                Console.Write(" / " + delitel + " = " + cis);
            } while (cis != 0);
            Console.ReadKey();
        }
    }
}
