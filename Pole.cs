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
            //string pole o 500 hodnotách
            string[] pole1 = new string[500];
            //pole2 char, naplňte hodnotami a e i o u y
            char[] pole2 = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            //pole3 a naplňte hodnotami 2,1 až 2,5
            double[] pole3 = new double[] { 2.1, 2.2, 2.3, 2.4, 2.5 };
            //pole4 pro 20 pravdostních hodnot
            bool[] pole4 = new bool[20];
            //pole5 pro 21 celých čísel
            int[] pole5 = new int[21];

            //naplňte pole5 náhodnými hodnotami o 100 do 200
            Random n = new Random();
            for (int i = 0; i < pole5.Length; i++)
            {
                pole5[i] = n.Next(100, 201);
            }
            //vypište pole5 ve formě "(index) - hodnota_indexu"
            for (int i = 0; i < pole5.Length; i++)
            {
                Console.WriteLine("(" + i + ") - " + pole5[i]);
            }
            Console.ReadKey();
        }
    }
}
