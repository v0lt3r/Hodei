using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace text_file_reader
{
    class Program
    {
        static ArrayList arrayfichero = new ArrayList();
        static int contador = 0;
        static void Main(string[] args)
        {
            ReadFile();
            ConsoleKeyInfo key;
            do
            {
                ShowInfo();
                DisplayFrom(contador);
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (contador + 21 < arrayfichero.Count)
                    contador++;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (contador > 0)
                    contador--;
                }          
            } while (key.Key != ConsoleKey.Escape);
        }

        static void ReadFile()
        {
            StreamReader fichero;
            string linea = "";
            fichero = File.OpenText("prueba.txt");
            
            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                {
                    arrayfichero.Add(linea);
                }
            } while (linea != null);
        }

        static void DisplayFrom(int n)
        {
            for (int i = n; i < arrayfichero.Count && i < n+21; i++)
            {
                Console.WriteLine(arrayfichero[i]);
            }
        }
        static void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("la linea en la que estamos es:" + (contador+1) + "-"+ (contador+21) + "/" + arrayfichero.Count);
        }
    }
}
