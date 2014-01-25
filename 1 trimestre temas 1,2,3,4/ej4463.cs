using System;

public class ej4463
{
	public static void Main (string[] args)
	{
		string linea;
		char [] delimitadores = { ' ', ',' , '.' };

		Console.WriteLine("introduce una frase");
		linea = Console.ReadLine();

		string [] palabras = linea.Split(delimitadores);

		for (int i = (palabras.Length-1); i >= 0; i--)
		{
			Console.Write("{0} ", palabras[i]);
		}
		Console.ReadKey();
	}
}

