using System;
using c = System.Console;

namespace prueba
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string> w = Console.Write;
			Action<string> wl = Console.WriteLine;


			w("hola");
			wl("linea");
			string hola = c.ReadLine();
		}
	}
}