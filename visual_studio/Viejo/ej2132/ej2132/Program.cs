using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2132
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("introduzca el primer numero:");
            num1 = Convert.ToInt32 ((Console.ReadLine()));
            Console.Write("introduzca el segundo numero:");
            num2 = Convert.ToInt32((Console.ReadLine()));

            if (num2 != 0)
            {
                double division = num1 / num2;
                Console.WriteLine("el resultado de los numeros divididos es:" + "\n" + division);
            }
            else
                Console.WriteLine("error, no se puede dividir entre 0");
        }
    }
}
