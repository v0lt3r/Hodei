
using System;
public class ej285
{
	public static void Main()
	{	
		int num1;
		Console.Write("Introduzca el numero de asteriscos: ");
		num1 = int.Parse(Console.ReadLine());
		for (int i=0; i<num1; i++)
		{
			for (int k=0; k<(num1-i); k++)
			{
				Console.Write("*");								
			}	
			Console.WriteLine();
		}
	}
}

