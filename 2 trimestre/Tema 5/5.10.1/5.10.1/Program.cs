using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10._1
{
    class Program
    {
        public static double potencia(int num, int exp)
        { 
            if (exp == 0)
            {
                return 1;
            }
            else
            {
                return num * potencia(num, exp - 1); 
            }
        }
        static void Main(string[] args)
        {
            int num = 2;
            int exp = 5;

            Console.WriteLine("la potencia de " + num + "^" + exp + " es: " + potencia(num, exp));
        }
    }
}
