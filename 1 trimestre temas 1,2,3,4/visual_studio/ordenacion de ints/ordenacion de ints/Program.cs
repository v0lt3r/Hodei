using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenacion_de_ints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
			{ 
                Console.WriteLine("escriba el numero {0} a añadir:", i);
                array[i] = Convert.ToInt16 (Console.ReadLine());
			}

            int temp = 0;

            for (int i=1; i<array.Length-1; i++)
            {
                for (int j=i+1; j == array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                       temp = array[j];
                       array[j] = array[i];
                       array[i] = temp;
                    }


                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
