using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10._4
{
	class Program
	{
		static string array = "546324543";

		public static int funcion(string arra)
		{
			if (arra.Length == 1)
				return Convert.ToInt32(arra.Substring(0, 1));
			else
				return Convert.ToInt32(arra.Substring(0, 1)) + funcion(arra.Substring(1));
		}

		static void Main(string[] args)
		{
			Console.WriteLine("la suma de los elementos de {0} es {1}", array , funcion(array));
			Console.Read();
        }
    }
}
