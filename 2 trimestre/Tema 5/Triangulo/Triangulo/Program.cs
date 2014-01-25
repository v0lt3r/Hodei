using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    class Program
    {
        public static long fibo(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            return fibo(n - 1) + fibo(n - 2);
        }

        public static int WriteTriangle(int width, int max, char letter)
        {

            for (int i = 0; ((i < max) && (i < (width+1)/2)); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('_');
                }
                for (int k = 0; k < width - i*2; k++)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
            }

            return 1;
        }

        static void Main(string[] args)
        {
            int largo;
            int maximo;
            string letra;

            Console.WriteLine("Introduzca el largo del triangulo");
            if (int.TryParse(Console.ReadLine(), out largo))
            {
                Console.WriteLine("Introduzca el maximo de altura del triangulo");
                if (int.TryParse(Console.ReadLine(), out maximo))
                {
                    Console.WriteLine("Introduzca el caracter");
                    letra = Console.ReadLine();
                    WriteTriangle(largo, maximo, letra[0]);
                }
            }
            else
                Console.WriteLine("error");
        }
    }
}
