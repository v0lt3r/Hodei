using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej464
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[500];
            int index = 0;
            int dato = 0;
            string tempdato = "";
            do
            {
                Console.WriteLine("introduzca un numero - escriba fin si desea salir del programa");
                tempdato = Console.ReadLine();
                if (int.TryParse(tempdato, out dato) == true)
                {
                    array[index] = dato;
                    index++;
                    int j = index - 1;
                    int datotemporal;

                    while ((j > 0) && (array[j] < array[j - 1]))
                    {
                        datotemporal = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = datotemporal;
                        j--;
                    }
                }
                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine(array[i]);
                }
            } while (tempdato != "fin");
        }
    }
}
