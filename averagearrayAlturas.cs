using System;

public class Arrays02
{
    public static void Main()
    {
		int[] medida =  new int[5];  
		string[] nombre = new string[5];
		
		for(int i = 0; i < medida.Length; i++) 
		{	
			Console.Write("introduce la medida {0}: ", i+1);
			medida[i] = Convert.ToInt32(Console.ReadLine());
			Console.Write("introduce el nombre {0}: ", i+1);
			nombre[i] = Console.ReadLine();
		}
		
		int suma = 0;
		
		for (int i = 0; i < medida.Length; i++)
			suma = suma + medida[i];
			
		int media = suma/medida.Length;
		
		Console.WriteLine("La altura media es: {0}", media);
		
		for(int i = 0; i< medida.Length; i++)
		{
			if (medida[i] > media)
				Console.WriteLine("{0} esta' por encima de la media", nombre[i]);
		}
	}
}
