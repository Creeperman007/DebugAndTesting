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
            Console.Write("Zadej délku strany (v cm): ");
            double strana_a_cm = Convert.ToDouble(Console.ReadLine());
            if (strana_a_cm > 0)
            {
                Console.WriteLine("Zadej operaci\n\tobvod\n\tobsah");
                string vzorec = Console.ReadLine();
                if (vzorec == "obvod")
                {
                    double obvod = 4 * strana_a_cm;
                    Console.WriteLine("Obvod čtverce je " + obvod + "cm.");
                }
                else if (vzorec == "obsah")
                {
                    double obsah = strana_a_cm * strana_a_cm;
                    Console.WriteLine("Obsah čtverce je " + obsah + "cm2.");
                }
                else
                {
                    Console.WriteLine("Chyba na vstupu");
                }
            }
            else
            {
                Console.WriteLine("Chyba na vstupu");
            }
            Console.ReadKey();
        }
    }
}
