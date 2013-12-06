using System;

public class Arrays02
{
    public static void Main()
    {
        int[] data =  new int[10];   

        for (int i=0;i<10;i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            data[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for (int i=0;i< 10;i++)
            Console.Write("{0} ", data[i]);   
        Console.Write("\n");

		int maxnumber = 0;
		
        for (int i=0; i < data.Length; i++)
            if (data[i] > maxnumber)
				maxnumber = data[i];
 
        Console.WriteLine("El maximo introducido es: {0}", maxnumber); 
    }
}

devenv.exe /diff ej4113.cs arraystruct.cs