
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
		
		int i = 0;
		while(i < alto)
		{
			int j = 0; 
			while(j < ancho)
			{
				Console.Write("*");
				j++;
			}
			Console.Write("\n");
			i++;
		}
		
		Console.WriteLine("");
		Console.WriteLine("Adios.");
	}
}
