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
                do
                {
                    Console.WriteLine("introduzca un numero (fin para salir -- consulta para buscar)");
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
                        for (int i = 0; i < index; i++)
                        {
                            Console.WriteLine(array[i]);
                        }
                    }
                } while ((tempdato != "consulta") && (tempdato != "fin"));

                if (tempdato == "consulta")
                {
                    int numbuscar;
                    Console.WriteLine("que numero debo de buscar?");
                    int.TryParse(Console.ReadLine(), out numbuscar);
                    int temp1 = 0;
                    int temp2 = array.Length-1;
                    int i = temp2 / 2; //+1

                    int flag = 0;
                    while (flag == 0)
                    {
                        if (array[i] > numbuscar)
                        {
                            temp2 = i;
                            i = (temp2 - temp1) / 2 + temp1;
                        }
                        if (array[i] < numbuscar)
                        {
                            temp1 = i;
                            i = (temp2 - temp1) / 2 + temp1;
                        }
                        if (array[i] == numbuscar)
                        {
                            flag = 2;
                        }
                        if (array[temp1] == numbuscar)
                        {
                            i = temp1;
                            flag = 2;
                        }
                        if (array[temp2] == numbuscar)
                        {
                            i = temp2;
                            flag = 2;
                        }
                        if (temp1 + 1 == temp2)
                        {
                            flag = 1;
                        }
                    }
                    if (flag ==2)
                        Console.WriteLine("el numero {0} se encuentra en la posicion {1}", array[i], i);
                    if (flag ==1)
                        Console.WriteLine("el numero no se encuentra en la base de datos.");                        
                }

            } while (tempdato != "fin");
        }
    }
}
