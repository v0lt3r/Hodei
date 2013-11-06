
using System;
public class Ejemplo2_8_4
{
	public static void Main()
	{
		int ancho;
		int alto;
		Console.Write("Introduzca el ancho de rectangulo: ");
		ancho = int.Parse(Console.ReadLine());
		Console.Write("Introduzca el alto del rectangulo: ");
		alto = int.Parse(Console.ReadLine());
		
		for (int i = 0; i < alto ; i++)
		{
			for (int j = 0; j < ancho ; j++)
			{
				Console.Write("*");
			}
			Console.Write("\n");
		}
		
		Console.WriteLine("");
		Console.WriteLine("Adios.");
	}
}
