using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NahodneCislo
{
    class Nahoda
    {
        static void Main(string[] args)
        {
            Random nahoda = new Random(); //vytvaří proměnnou, která generuje náhodná čísla
            int cislo = nahoda.Next(1, 101); //generuje náhodné číslo od 1 do 100 (k vyššímu číslu se musí přičíst 1)

            //ukázka, že kód funguje
            Console.WriteLine(cislo); //vypisuje číslo, které se vygenerovalo
            Console.ReadKey();
        }
    }
}
