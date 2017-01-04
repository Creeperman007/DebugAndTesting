using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KladneZaporne
{
    class Trujuhelnik_strany
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej stranu a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej stranu b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej stranu c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a + b > c) && (b + c > a) && (a + c > b)) //lze sestrojit?
            {
                Console.Write("Trojúhelník je ");
                if (a == b && b == c)
                {
                    Console.WriteLine("rovnostranný");
                }
                else if (a != b && b != a && c != a)
                {
                    Console.WriteLine("obecný");
                }
                else if ((a == b && b != c) || (b == c && c != a) || (a == c && c != b)) //od if nemusí být
                {
                    Console.WriteLine("rovnoramenný");
                }
            }
            else
            {
                Console.WriteLine("Trojúhelník nelze sestrojit");
            }
            Console.ReadKey();
        }
    }
}
