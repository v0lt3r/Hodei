using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Invert_a_text_file
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader ficha;

            ficha = File.OpenText("fichero.txt");
            int contador = 0;
            string linea;

            do
            {
                linea = ficha.ReadLine();
                contador++;
            } while (linea != "");
            contador--;
            ficha.Close();

            string [] array = new string [contador];
            ficha = File.OpenText("fichero.txt");
            for (int i = contador-1; i >= 0; i--)
            {
                array[i] = ficha.ReadLine();
            }
            ficha.Close();

            StreamWriter fichero;
            fichero = File.CreateText("fichero.tnv");

            for (int i = 0; i < contador; i++)
            {
                fichero.WriteLine(array[i]);
            }

            fichero.Close();
            
        }
    }
}
