using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            /*                                \/ spoštění programu*/
            Console.WriteLine("součet je " + secist(1, 22, 8));
            Console.WriteLine("rozdíl je " + odecist(85, 45));
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("součet " + secist(1, 1, i));
                Console.WriteLine("rozdíl " + odecist(10, i));
                Console.WriteLine("násobek " + vynasobit(2, i));
                Console.WriteLine("-----------");
            }
            
        }
        //podprogram = metoda
        //definice metody = programu
        
        public static int secist(int cislo1, int cislo2, int cislo3)
        {
            return cislo1 + cislo2 + cislo3;
        }
        public static int odecist(int cislo1, int cislo2)
        {
            return cislo1 - cislo2;
        }
        public static int vynasobit(int cislo1, int cislo2)
        {
            return cislo1 * cislo2;
        }
    }
}
