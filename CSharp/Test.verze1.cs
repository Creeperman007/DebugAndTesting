using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy
{
    class Program
    {
        static void Main(string[] args)
        {
            double stav_uctu = 12552;
            Console.Write("Zadejte cenu zboží: ");
            double cena_zbozi = Convert.ToDouble(Console.ReadLine());
            if (cena_zbozi <= stav_uctu)
            {
                stav_uctu = stav_uctu - cena_zbozi;
                Console.WriteLine("Aktuální stav účtu je: " + stav_uctu + " Kč.");
            }
            else
            {
                Console.Write("Opravdu se přejete provést transakci? (y/n): ");
                char o = Convert.ToChar(Console.ReadLine());
                if (o == 'n')
                {
                    Console.WriteLine("Operace byla zrušena");
                }
                else
                {
                    stav_uctu = stav_uctu - cena_zbozi;
                    Console.WriteLine("Aktuální stav účtu je: " + stav_uctu + " Kč.");
                }
            }
            Console.ReadKey();
        }
    }
}
