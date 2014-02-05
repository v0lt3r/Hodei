using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace More
{
    class Program
    {
        static int Main(string[] args)
        {
            string nombre;
            if (args.Length == 0)
            {
               Console.WriteLine("escriba el nombre deseado");
               nombre = Console.ReadLine();
            }
            else if (args.Length == 1)
            {
                nombre = args[0];
            }
            else 
            {
                return -1;
            }

            StreamReader fichero;
            string linea = " ";
            fichero = File.OpenText(nombre);

            while (linea != null)
            {
                for (int i = 0; i < 24; i++)
                {
                    linea = fichero.ReadLine();
                    if (linea != null)
                    {
                        for (int k = 0; (k < 79 && k < linea.Length); k++)
                        {
                           Console.Write(linea[k]);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        i = 25;
                    }
                }
                if (linea != null)
                {
                    Console.WriteLine("pulsar una tecla ....");
                    Console.ReadKey();
                }
            }
            fichero.Close();

            return 0;
        }
    }
}
