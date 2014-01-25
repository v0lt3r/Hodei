using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{
	public class Program
	{
		struct datosciudad
		{
			public string nombre;
			public int nhabitantes;
		}

		public static void Main(string[] args)
		{
			datosciudad[] ciudad = new datosciudad[500];
			byte opcion;
			int index = 0;
			byte posicion_dato;

			do
			{
				Console.WriteLine("Elige una opcion:");
				Console.WriteLine("1. Add a new city");
				Console.WriteLine("2. View all cities");
				Console.WriteLine("3. Modify a record");
				Console.WriteLine("4. Insert a new record");
				Console.WriteLine("5. Delete a record");
				Console.WriteLine("6. Search in the records");
				Console.WriteLine("7. Correct the capitalization of the names");
				Console.WriteLine("0. Exit");
				byte.TryParse(Console.ReadLine(), out opcion);
				Console.Clear();

				switch (opcion)
				{
					case 1: // añade datos al final
						Console.WriteLine("Escriba una ciudad a añadir:");
						ciudad[index].nombre = Console.ReadLine();
						Console.WriteLine("Escriba un numero de habitantes a añadir:");
						ciudad[index].nhabitantes = Convert.ToInt16 (Console.ReadLine());
						index++;
					break;

					case 3: // modificar datos

						Console.WriteLine("Escriba el indice del dato a modificar:");
					posicion_dato = Convert.ToInt16.ReadLine();
					if (posicion_dato < index)
					{
						Console.WriteLine("Escriba una ciudad a añadir:");
						ciudad[posicion_dato].nombre = Console.ReadLine();
						Console.WriteLine("Escriba un numero de habitantes a añadir:");
						ciudad[posicion_dato].nhabitantes = Convert.ToInt32 (Console.ReadLine());
					}
					else
						Console.Write("el indice introducido es mayor que el de la base de datos");
					break;

					case 4: //Insertar un dato en una cierta posición
                        Console.WriteLine("Escriba la posicion donde desea añadir el dato");
					if (byte.TryParse(Console.ReadLine(), out posicion_dato))
					{
						if (posicion_dato <= index)
						{
							for (int i = index -1; i >= posicion_dato - 1; i--)
							{
								ciudad[i + 1].nombre = ciudad[i].nombre;
								ciudad[i + 1].nhabitantes = ciudad[i].nhabitates;
							}

							Console.WriteLine("Escriba un dato a añadir:");
							nombres[posicion_dato - 1] = Console.ReadLine();
							index++;
						}	
					}
                        break;
                    
                    case 5: //Borrar el dato que hay en una cierta posición
                        Console.WriteLine("Escriba la posicion que quiera borrar");
                        if (byte.TryParse(Console.ReadLine(), out posicion_dato))
                        {
                            if (posicion_dato < index)
                            {
                                for (int i = posicion_dato - 1; i < index; i++)
                                {
                                   	ciudad[i].nombre = ciudad[i + 1].nombre;
									ciudad[i].nhabitantes = ciudad[i + 1].nhabitates;
                                }
                                index--;
                            }
                        }
                        break;
                    
                    case 2: //Mostrar los datos que contiene el array.
                        for (int i = 0; i < index; i++)
                        {
                            Console.Write("{0} -> {1} \t", ciudad[i].nombre, ciudad[i].nhabitantes);
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    
                    case 0: //Salir del programa.
                        break;

                    default:
                        break;
                }
            } while (opcion != 0);          
        }   
    }
}

