using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4433
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Escriba el primer numero");
			string text1 = Console.ReadLine();
			Console.WriteLine("Escriba el segundo numero");
			string text2 = Console.ReadLine();
			int [] textMod1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			int [] textMod2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

			int itemp = 0;
			for (int i = text1.Length - 1; i >= 0; i--)
			{
				textMod1[itemp] = (int)Char.GetNumericValue(text1[i]);
				if(textMod1[itemp] > 0)
					itemp++;
				else
				{
					Console.WriteLine("La primera cadena no es un numero");
					Console.WriteLine("Pulse una tecla");
					Console.ReadKey();
					return;
				}
			}

			itemp = 0;
			for (int i = text2.Length - 1; i >= 0; i--)
			{
				textMod2[itemp] = (int)Char.GetNumericValue(text2[i]);
				if(textMod2[itemp] > 0)
					itemp++;
				else
				{
					Console.WriteLine("La segunda cadena no es un numero");
					Console.WriteLine("Pulse una tecla");
					Console.ReadKey();
					return;
				}
			}

			int llevada = 0;
			int [] resultado = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

			for (int i = 0; i < 30; i++)
			{
				llevada += textMod1[i] + textMod2[i];
				if (llevada > 9)
				{
					resultado[i] = (llevada%10);
					llevada = (llevada/10);
				}
				else
				{
					resultado[i] = (llevada);
					llevada = (0);
				}
			}

			resultado[30] = (int)(llevada/10);

			// para quitar los "0" iniciales
			int flag = 0;
			for (int i = 30; i >= 0; i--)
			{
				if(resultado[i] != 0 || flag == 1)
				{
					Console.Write(resultado[i]);
					flag =1;
				}
			}
			Console.WriteLine();
			
			Console.WriteLine("Pulse una tecla");
			Console.ReadKey();
		}
    }
}

