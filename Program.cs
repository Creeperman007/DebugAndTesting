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
            Matematika pche = new Matematika();
            Console.WriteLine(pche.VypisLinRovnici()); //výpis rovnice
            pche.InvertujParametry(); //inverze parametrů
            pche.NastavParametry(10, 5); //nastavení parametrů
            Console.WriteLine(pche.JeSude(8)); //ověření, žda je číslo sudé
            Console.WriteLine(pche.ToString()); //funkce ToString()

            Console.ReadKey();
        }
    }
}
