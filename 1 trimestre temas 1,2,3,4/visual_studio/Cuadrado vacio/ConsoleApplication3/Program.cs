using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen01hperez2
{
    class program
    {
        public static void Main()
        {
            int numero;
            Console.Write("Introduzca un numero impar: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la palabra a repetir");
            string variable = Console.ReadLine();
            Console.WriteLine("");

            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    if ((i == 0) || (i == numero - 1) || (j == 0) || (j == numero - 1) || (i%2 == 0))
                        Console.Write(variable);
                    else
                        for (int k = 0; k < variable.Length; k++)
                        {
                            Console.Write(" ");
                        }
                }
                Console.Write("\n");
            }
            Console.WriteLine("");
            Console.ReadKey();
            // la unica condicion que no se me ocurre es como escribir una fila si y otra no. 
        }
    }
}
