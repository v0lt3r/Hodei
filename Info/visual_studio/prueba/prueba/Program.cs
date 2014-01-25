using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using c = System.Console;
using read = Console.ReadLine;
using write = Console.Write;
using writeL = Console.WriteLine;
namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENCONTRAR VALOR MAXIMO DE UN ARRAY INTRODUCIDO POR EL USUARIO

            int[] anArray = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                anArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxValue = anArray.Max();
            int maxIndex = anArray.ToList().IndexOf(maxValue);
            Console.WriteLine(maxValue);

            /* 
            ENCONTRAR MAXIMO DE UN ARRAY CON VALORES PREDETERMINADOS
             
                int[] anArray = { 1, 5, 2, 7 };
                int maxValue = anArray.Max();
                int maxIndex = anArray.ToList().IndexOf(maxValue);
                Console.WriteLine(maxValue);
            */
        }
    }
}
