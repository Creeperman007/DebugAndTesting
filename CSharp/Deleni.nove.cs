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
            //Dělení s desetinným číslem
            int a = 60;
            int b = 7;
            double podil = (double)a / (double)b; //převádí čísla a, b na double, aby bylo možno vytvořit desetinné číslo. převést stačí pouze jedno číslo

            //zobrazení výsledku
            Console.WriteLine(podil);

            //Dělení se zbytkem
            int x = 70;
            int y = 3;
            int Podil = x / y; //není potřeba převádět proměnné do double, protože nechceme desetinné číslo
            int zbytek = x % y; // značka procenta "%" je předdefinovaná funkce, které slouží k výpočtu zbytku

            //zobrazení výsledku
            Console.WriteLine("podíl: " + Podil + "\nzbytek: " + zbytek);

            Console.ReadLine();
             
        }
    }
}
