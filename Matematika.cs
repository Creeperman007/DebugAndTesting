using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Matematika
    {
        double parametr_a = 10;
        double parametr_b = 5;

        public string VypisLinRovnici()
        {
            if (parametr_b >= 0)
                return String.Format("y = {0}x + {1}", parametr_a, parametr_b);
            else
                return String.Format("y = {0}x - {1}", parametr_a, -1*parametr_b);
        }
        public void InvertujParametry()
        {
            parametr_a *= -1;
            parametr_b *= -1;
        }
        public void NastavParametry(double a, double b)
        {
            parametr_a = a;
            parametr_b = b;
        }
        public bool JeSude(double cislo)
        {
            if (cislo % 2 == 0)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}", parametr_a, parametr_b);
        }
    }
}
