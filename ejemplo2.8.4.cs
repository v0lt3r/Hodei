
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
		do
		{
			int j = 0; 
			do
			{
				Console.Write((i+j)%10);
				j++;
			}
			while(j < ancho);
			Console.Write("\n");
			i++;
		}
		while(i < alto);

		
		Console.WriteLine("");
		Console.WriteLine("Adios.");
	}
}
