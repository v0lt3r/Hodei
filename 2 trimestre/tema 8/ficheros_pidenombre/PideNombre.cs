using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace ficheros_pidenombre
{
    class PideNombre
    {
        static void Main(string[] args)
        {
            string nombreOrigen;
            string nombreDestino;
            StreamReader fichero1 = null;
            StreamWriter fichero2 = null;
            Boolean flag = true;
            string linea = "";

            Console.WriteLine("Escriba el nombre del fichero de origen");
            do{
                nombreOrigen = Console.ReadLine();
                try
                {
                    fichero1 = File.OpenText(nombreOrigen);
                    flag = false;
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Escriba el nombre del un fichero existente");
                    flag = true;
                }
            } while (flag == true);

            Console.WriteLine("Escriba el nombre del fichero de destino");
            do
            {
                nombreDestino = Console.ReadLine();
                try
                {
                    fichero2 = File.CreateText(nombreDestino);
                    flag = false;
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Escriba el nombre del un fichero existente");
                    flag = true;
                }
            } while (flag == true); 

            while (linea != null)
            {
                linea = fichero1.ReadLine();
                if (linea != null)
                    fichero2.WriteLine(linea.ToUpper());
            }
            fichero1.Close();
            fichero2.Close();
        }
    }
}
