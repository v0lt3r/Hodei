using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4431
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Escriba el nombre a modificar");
			string text = Console.ReadLine();
			for (int i = 0; i<text.Length; i++)
			{
				Console.Write(text[i]);
				Console.Write(' ');
			}
			Console.ReadKey();
		}
    }
}

