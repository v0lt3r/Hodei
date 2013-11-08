
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
			Console.WriteLine("*");			
			for (int k=0; k<num1; k++)
			{
				Console.Write("*");								
			}	
		}
	}
}
_____________________________________
/*


using System;
public class ej285
{
	public static void Main()
	{	
		int num1;
		int i = 0;
		int k = 0;
		Console.Write("Introduzca el numero de asteriscos: ");
		num1 = int.Parse(Console.ReadLine());
		while (i<num1)
		{
			Console.Write("*");	
			i++;		
			while (k<(num1+1))
			{
				Console.WriteLine("*");	
				k++;			
			}						
		}
	}
}
*/
