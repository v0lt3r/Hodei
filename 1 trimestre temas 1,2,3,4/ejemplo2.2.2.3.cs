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
		string valida1 = "pedro";
		string valida2 = "peter";
		string usuario;
		string clave;

		Console.Write("Introduzca el nombre de usuario: ");
		usuario = Console.ReadLine();
		Console.Write("Introduzca su clave: ");
		clave = Console.ReadLine();

		while ((usuario != valida1) || (clave != valida2))
		{
			if ((usuario != valida1) || (clave != valida2)) {
				Console.WriteLine("Acceso denegado!");
				Console.Write("Introduzca el nombre de usuario: ");
				usuario = Console.ReadLine();
				Console.Write("Introduzca su clave: ");
				clave = Console.ReadLine();
			}
		}
		
		Console.WriteLine("Bienvenido.");
	}
}
