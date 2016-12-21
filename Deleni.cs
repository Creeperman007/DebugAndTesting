using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deleni
{
    class Deleni
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej dělenec: ");
            double delenec = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zadej dělitel: ");
            double delitel = Convert.ToDouble(Console.ReadLine());
            if (delitel != 0)
            {
                double podil = delenec / delitel;
                Console.WriteLine("Podíl je: " + podil);
            }
            else
            {
                Console.WriteLine("Nulou nelze dělit");
            }
            Console.ReadKey();
        }
    }
}
