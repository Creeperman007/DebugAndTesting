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
            Random nahoda = new Random();
            int c = nahoda.Next(0, 101);
            int tip = 101;
            int p = 0;
            do
            {
                p++;
                Console.Write("tip: ");
                tip = Convert.ToInt32(Console.ReadLine());
                if (tip > c)
                {
                    Console.WriteLine("Snižuj tip");
                }
                else if (tip < c)
                {
                    Console.WriteLine("Zvyšuj tip");
                }
                
            } while (tip != c);
            Console.WriteLine("OK - počet pokusů: " + p);
            Console.ReadKey();
        }
    }
}
