using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] nombres = new string[10];
            byte opcion;
            int index = 0;
            byte posicion_dato;

            do
            {
                Console.WriteLine("Elige una opcion:");
                Console.WriteLine("1. Añadir datos");
                Console.WriteLine("2. Insertar datos en una posicion");
                Console.WriteLine("3. Borrar dato de una posicion");
                Console.WriteLine("4. Mostrar datos que contiene el array");
                Console.WriteLine("5. Salir del programa");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();

                switch (opcion)
                {
                    case 1: // añade datos al final
                        Console.WriteLine("Escriba un dato a añadir:");
                        nombres[index] = Console.ReadLine();
                        index++;
                        break;
                    
                    case 2: //Insertar un dato en una cierta posición
                        Console.WriteLine("Escriba la posicion donde desea añadir el dato");
                        if (byte.TryParse(Console.ReadLine(), out posicion_dato))
                        {
                            for (int i = index; i >= posicion_dato - 1; i--)
                            {
                                if (i < nombres.Length)
                                    nombres[i + 1] = nombres[i];
                            }
                            Console.WriteLine("Escriba un dato a añadir:");
                            nombres[posicion_dato - 1] = Console.ReadLine();
                            index++;
                        }
                        break;
                    
                    case 3: //Borrar el dato que hay en una cierta posición
                        Console.WriteLine("Escriba la posicion que quiera borrar");
                        if (byte.TryParse(Console.ReadLine(), out posicion_dato))
                        {
                            if (posicion_dato - 1 < index)
                            {
                                for (int i = posicion_dato - 1; i < index; i++)
                                {
                                    nombres[i] = nombres[i + 1];
                                }
                                index--;
                            }
                        }
                        break;
                    
                    case 4: //Mostrar los datos que contiene el array.
                        for (int i = 0; i < index; i++)
                        {
                            Console.Write("{0} \t", nombres[i]);
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    
                    case 5: //Salir del programa.
                        break;

                    default:
                        break;
                }
            } while (opcion != 5);          
        }   
    }
}

