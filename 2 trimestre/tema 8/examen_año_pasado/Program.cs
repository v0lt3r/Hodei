using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace examen_año_pasado
{
    class Program
    {
        static void Main(string[] args)
        {
            // ej 1

            StreamReader fichero;
            string linea;
            fichero = File.OpenText("prueba.txt");
            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                {
                    string[] array2 = linea.Split('(');

                    string[] array = linea.Split('\'');

                    StreamWriter fichero2;

                }    
            }
            while (linea != null);
            fichero.Close();
        }
    }
}
