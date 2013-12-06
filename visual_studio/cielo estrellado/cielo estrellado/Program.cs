using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cielo_estrellado
{
	class Program
	{
		static void Main(string[] args)
		{
			const int longitud = 20;
			const int largo = 70;
			char[, ] estrellas = new char[longitud, largo];

			Random generador = new Random();
			for (int i = 0; i < longitud; i++)
			{
				for (int k = 0; k < largo; k++)
				{
					if (generador.Next(0, 2) == 1)
						estrellas[i, k] = '*';
					else
						estrellas[i, k] = ' ';
				}
			}

			for (int i = 0; i < longitud; i++)
			{
				for (int k = 0; k < largo; k++)
				{
					Console.Write(estrellas[i, k]);
				}

				Console.WriteLine();
			}
			Console.WriteLine("Pulsa una tecla ... ");			
			Console.ReadKey();
        }
    }
}
