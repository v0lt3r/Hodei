using System;

namespace ej5_10_10
{
    class Program
    {
        public static int numera(string frase, string palabra, int n)
        {
            if (frase.Length == palabra.Length)
            {
                if (frase == palabra)
                {
                    return 1;
                }
                else
                    return 0;
            }
            else
            {
                int count = 0;

                for (int i = n; i < (frase.Length); i++)
                {
                    count += numera(frase.Remove(i, 1), palabra, i);
                }

                return count;
            }
        }

        static void Main(string[] args)
        {
            string frase;
            string palabra;

            Console.WriteLine("Insertar la frase de referencia:");
            frase = Console.ReadLine();
            Console.WriteLine("Insertar la palabra que hay que buscar:");
            palabra = Console.ReadLine();

            frase = frase.ToLower();
            palabra = palabra.ToLower();

            Console.WriteLine("La palabra '" + palabra + "' esta' contenida en '" + frase + "' " + numera(frase, palabra, 0) + " veces.");

            Console.WriteLine("Pulsar una tecla ...");
            Console.ReadKey();
        }
    }
}