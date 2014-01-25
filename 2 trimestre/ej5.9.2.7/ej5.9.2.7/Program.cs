using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5._9._2._7
{
    class Program
    {
        static int ancho = 79;
        static int alto = 24;

        static char[,] array = new char[alto, ancho];

        public static int dibujar (int x)
        {
            return (int)(10 * (Math.Sin(x * 5)));
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < alto; i++)
            {
                for (int k = 0; k < ancho; k++)
                {
                    array[i, k] = ' ';
                }
            }

            for (int i = 0; i <= 72; i++)
            {
                array[(dibujar(i)+alto/2), i] = '*';
            }

            for (int i = 0; i < alto; i++)
            {
                for (int k = 0; k < ancho; k++)
                {
                    Console.Write(array[i, k]);
                }
                Console.WriteLine();
            }
        }
    }
}
