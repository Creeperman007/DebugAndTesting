using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nejvetsi
{
    class Nejvetsi
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej první číslo: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zadej druhé číslo: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zadej třetí číslo: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine("Největší číslo je: " + max);
            Console.ReadKey();
        }
    }
}
