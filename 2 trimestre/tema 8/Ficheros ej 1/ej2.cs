using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficheros_ej_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombrealumno;
            StreamWriter fichero;
            Console.WriteLine("escriba el nombre del fichero");
            string nombre = Console.ReadLine();
            fichero = File.CreateText(nombre + ".txt");

            do
            {
                Console.WriteLine("escriba el nombre del alumno");
                nombrealumno = Console.ReadLine();
                fichero.WriteLine(nombrealumno);
                if (nombrealumno == "FIN")
                {
                    fichero.Close();
                    return;
                }
                Console.WriteLine("escriba la nota de teoria");
                int notateoria = Convert.ToInt32(Console.ReadLine());
                fichero.WriteLine(notateoria);

                Console.WriteLine("escriba la nota de practica");
                int notapractica = Convert.ToInt32(Console.ReadLine());
                fichero.WriteLine(notapractica);
            } while (nombrealumno != "FIN");
        }
    }
}
