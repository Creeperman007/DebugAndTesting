using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double zakladni_cena = 999;
            Console.Write("Pohlaví (muž/žena): ");
            string pohlavi = Console.ReadLine();
            Console.Write("Váš věk: ");
            Int16 vek = Convert.ToInt16(Console.ReadLine());
            Console.Write("Cena předplatného je ");
            if (pohlavi == "žena")
            {
                zakladni_cena = zakladni_cena - 100;
                if (vek >= 60)
                {
                    zakladni_cena = zakladni_cena * 0.9;
                    Console.WriteLine(zakladni_cena);
                }
                else
                {
                    Console.WriteLine(zakladni_cena);
                }
            }
            else
            {
                if (vek >= 60)
                {
                    zakladni_cena = zakladni_cena * 0.9;
                    Console.WriteLine(zakladni_cena);
                }
                else
                {
                    Console.WriteLine(zakladni_cena + " Kč");
                }
            }
            Console.ReadKey();
        }
    }
}
