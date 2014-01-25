using System;
using c = System.Console;

namespace a
{
	class a
	{
		//ATAJOS		
		static string read()
		{
			return Console.ReadLine();
		}

		static int read_convert()
		{
			return Convert.ToInt32(read());
		}

		//PROGRAMA		
		static void Main(string[] args)
		{
			Action<string> write = Console.Write;
			Action<string> writeL = Console.WriteLine;

			int numero = read_convert();
			write("hola");
			writeL("linea");
		}
	}
}