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
			int bandera = 0;
			do
			{
				bandera = 0;
				for (int j = 0; j < array.Length-2; j++)
				{
					if (array[j] > array[j+1])
					{
						temp = array[j];
						array[j] = array[j+1];
						array[j+1] = temp;
						bandera = 1;
					}
				}
			}
			while (bandera == 1);
			
			// int temp = 0;
			// for (int i=1; i<array.Length; i++)
			// {
				// for (int j=array.Length - 1 ; j >= i; j--)
				// {
					// if (array[j - 1].CompareTo(array[j]) > 0)
					// {
					   // temp = array[j - 1];
					   // array[j - 1] = array[j];
					   // array[j] = temp;
					// }
				// }
			// }


				for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
			}
			Console.ReadKey();
        }
    }
}
