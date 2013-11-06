/*---------------------------*/
/* Ejemplo en C# nº 18: */
/* ejemplo18.cs */
/* */
/* La orden "do..while" (2) */
/* */
/* Introduccion a C#, */
/* Nacho Cabanes */
/*---------------------------*/

using System;
public class Ejemplo18
{
	public static void Main()
	{
		string valida = "secreto";
		string clave;
		do
		{
			Console.Write("Introduzca su clave: ");
			clave = Console.ReadLine();
			if (clave != valida)
				Console.WriteLine("No válida!");
		}
		while (clave != valida);
		Console.WriteLine("Aceptada.");
	}
}