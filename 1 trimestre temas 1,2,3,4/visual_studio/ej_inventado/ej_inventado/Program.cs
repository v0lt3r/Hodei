using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crear un menu, con 5 opciones del 1 al 5 y el 0 para salir. Si el usuario pone una opcion incorrecta o la opcion de menu no existe, mostrar un mensaje y volver a aparecer el menu.
*/
namespace ej_inventado
{
    class Program
    {
        struct perro
	    {
		   public string nombre;
           public string raza;
           public byte mes;
           public byte anyo; 
	    }
        static void Main(string[] args)
        {
            perro[,] perros = new perro[4,5];
            int opcion;
            int index;
            do
            {
                    
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine("5");
                Console.WriteLine("0 - Salir");

                if (int.TryParse(Console.ReadLine(), out opcion) == false)
                {
                    opcion = -1;
                    Console.WriteLine("Error, la cadena de entrada no tiene le formato correcto");
                }

                else
                {
                    switch (opcion)
                    {
                        case 1: // insertar nombre y raza y fecha_entrada de perros, si no esta vacio que diga si hay un dato, seguro que quieres borrarlo?
                            string temp;
                            byte tempfecha;
                            int posicionx;
                            int posiciony;

                            Console.WriteLine("escriba la posicion x donde desea insertar el perro");
                            int.TryParse(Console.ReadLine(), out posicionx);
                            Console.WriteLine("escriba la posicion y donde desea insertar el perro");
                            int.TryParse(Console.ReadLine(), out posiciony);

                            Console.WriteLine("escriba el nombre del perro");
                            temp = Console.ReadLine();
                            perros[posicionx, posiciony].nombre = temp;
                           
                            Console.WriteLine("escriba el raza del perro");
                            temp = Console.ReadLine();
                            perros[posicionx, posiciony].raza = temp;

                            Console.WriteLine("escriba el año del perro");
                            byte.TryParse(Console.ReadLine(), out tempfecha);
                            perros[posicionx, posiciony].anyo = tempfecha;

                            Console.WriteLine("escriba el mes del perro");
                            byte.TryParse(Console.ReadLine(), out tempfecha);
                            perros[posicionx, posiciony].mes = tempfecha;

                        break;

                        case 2: // mostrar todos los datos

                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                
                            }
                        }

                        break;

                        case 3: // quien hay en una cierta posicion
                        break;

                        case 4: // intercambiar 2 perros de sitio
                        break;

                        case 5: // borrar perros
                        break;

                        case 6: // mostrar todos los perros a partir de una fecha
                        break;

                        case 7: // buscar nombre
                        break;

                        default:
                            if (opcion != 0)
                            Console.WriteLine("error, opcion no valida");
                        break;
                    }
                }
            } while (opcion != 0);
        }
    }
}
