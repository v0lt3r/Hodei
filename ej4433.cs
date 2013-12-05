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
			string text = Console.ReadLine();
			Console.WriteLine("Escriba el segundo numero");
			string text2 = Console.ReadLine();

			if (text.Length > text2.Length)
			{
				for (int i = 0; i < (text.Length-text2.Length); i++)
				{
					text2.Insert(0, "0");
				}
			}

			if (text.Length < text2.Length)
			{
				for (int i = 0; i < (text2.Length-text.Length); i++)
				{
					text.Insert(0, "0");
				}

				int longitud = text2.Length;
			}

			int llevada = 0;
			int num1;
			int num2;
			string resultado = "";

			for (int i = text.Length - 1; i >= 0; i--)
			{
				
				num1 = (int)Char.GetNumericValue(text[i]);
				num2 = (int)Char.GetNumericValue(text2[i]);

				llevada += num1 + num2;
				if (llevada > 9)
				{
					resultado.Insert(0, (llevada%10).ToString() );
					llevada -= llevada%10;
				}

				// else
				// {
					// Console.WriteLine("Una de las dos cadenas no es un numero");
					// Console.WriteLine("Pulse una tecla");
					// Console.ReadKey();
					// return;
				// }
			}

			resultado.Insert(0, (llevada/10).ToString());

			for (int i = resultado.Length-1; i >= 0; i--)
			{
				Console.Write(resultado[i]);
			}
			Console.WriteLine();
			
			Console.WriteLine("Pulse una tecla");
			Console.ReadKey();
		}
    }
}

