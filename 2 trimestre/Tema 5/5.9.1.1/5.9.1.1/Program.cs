using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._9._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int numero = r.Next(1, 100);
            int contador = 0;
            int salida;
            while (contador < 6)
            {

                Console.WriteLine("intente adivinar el numero del 1 al 100 generado");
                int.TryParse(Console.ReadLine(), out salida);
                if (numero == salida)
                {
                Console.WriteLine("Ha acertado !!");
                contador = 7;
                }
                else
                {
                    if (numero > salida)
                    Console.WriteLine("El numero es mayor");

                    else
                    Console.WriteLine("El numero es menor");

                    Console.WriteLine("error, intentelo de nuevo");                   
                }
                contador++;
            }
        }
    }
}
