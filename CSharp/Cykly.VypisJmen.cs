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
            string jmena = "";
            string pass = "";
            int c = 1;
            do
            {
                Console.Write("Zadej " + c + ". jméno: ");
                jmena += Console.ReadLine() + ", ";
                Console.Write("\tChcete pokračovat? (a/n): ");
                pass = Console.ReadLine();
                c++;
            } while (pass != "n");
            Console.WriteLine(jmena);
            Console.ReadKey();
        }
    }
}
