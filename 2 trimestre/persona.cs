using System;

public class ejercicio
{
		public static void Main(string[] args)
	{
		int opcion = 0;
		do
		{
			Console.WriteLine("elija una opcion:");
			Console.WriteLine("1. Escribir nombre");
			Console.WriteLine("2. Saludar persona");
			Console.WriteLine("3. Salir");
			opcion = Convert.ToInt32(Console.ReadLine());
			if (opcion == 1)
			{
				Console.WriteLine("Escriba un nombre");
				Persona.SetNombre(Console.ReadLine());
			}
			else if (opcion == 2)
			{
				Persona.Saludar();
			}
		} while (opcion != 3);
	}
}


public class Persona
{
	static string Nombre;
	public static void SetNombre(string nombre)
	{
		Nombre = nombre;
	}

	public static void Saludar()
	{
		Console.WriteLine("hola soy " + Nombre);
	}
}
