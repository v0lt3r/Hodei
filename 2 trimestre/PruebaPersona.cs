using System;

public class PruebaPersona
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Introduzca nombre 1");
		Persona Persona1 = new Persona(Console.ReadLine());
		Persona1.Saludar();
		
		Console.WriteLine("Introduzca nombre 2");
		Persona Persona2 = new Persona(Console.ReadLine());
		Persona2.Saludar();
		
		Console.ReadLine();
		
	}
}


public class Persona
{
	static string Nombre;
	public Persona(string nombre)
	{
		Nombre = nombre;
	}

	public void Saludar()
	{
		Console.WriteLine("hola soy " + Persona.Nombre);
	}

}
