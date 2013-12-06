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
        Console.WriteLine("Introduce la palabra a repetir");
        string variable = Console.ReadLine();
        Console.WriteLine("");

        for (int i = 0; i < alto; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                if ((i == 0) || (i == alto - 1) || (j == 0) || (j == ancho - 1))
                    Console.Write(variable);
                else
                    for (int k = 0; k < variable.Length; k++)
                    {
                        Console.Write(" "); 
                    }
                    
            }
            Console.Write("\n");
        }

        Console.WriteLine("");
        Console.WriteLine("Adios.");
    }
}
