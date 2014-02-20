using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Program
    {
        const int numVehiculos = 10;
        static Vehiculo[] parking = new Vehiculo[numVehiculos];
        static int index;
        
        static void Main(string[] args)
        {
            int opcion;
            int opcion2;


            do
            {
                Console.Clear();
                Console.WriteLine("1. Añadir vehiculo");
                Console.WriteLine("2. Lista vehiculos");
                Console.WriteLine("3. Cambiar neumaticos");
                Console.WriteLine("4. Salida Vehiculo");
                Console.WriteLine("5. Salir del programa");
                Console.WriteLine();
                if (!int.TryParse(Console.ReadLine(), out opcion))
                    opcion = 6;

                switch (opcion)
                {
                    case 1:

                        if (index == numVehiculos-1)
                        {
                            Console.WriteLine("parking completo!");
                            break;
                        }

                        Console.WriteLine("quieres añadir un coche (1) o una moto (2)?");
                        while( !int.TryParse(Console.ReadLine(), out opcion2) || (opcion2 < 1 && opcion2 > 2) )
                        {
                            Console.WriteLine("Error (escriba 1 o 2)");
                            Console.WriteLine("quieres añadir un coche (1) o una moto (2)?");
                        }

                        if (opcion2 == 1)
                        {
                        }
                        else if (opcion2 == 2)
                        {
                            parking[index] = new Moto();
                        }
                        index++;
                        
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("Hasta luego !!!!!!!");
                        break;

                    default:
                        break;
                }

                if (opcion == 6)
                    Console.WriteLine("opcion no valida!");
                else
                    Console.WriteLine("... pulsa una tecla");
                Console.ReadLine();

            } while (opcion != 5);          
        }

        void introducirDatos(int opt)
        {
            string marca;
            string modelo;
            string conductor;
            string matricula;
            int radio;

            if (opt == 1)
                parking[index] = new Coche();
            else if (opt == 2)
                parking[index] = new Moto();

            Console.WriteLine("introduzca la marca");
            marca = Console.ReadLine();
            Console.WriteLine("introduzca el modelo");
            modelo = Console.ReadLine();
            Console.WriteLine("introduzca el nombre del conductor");
            conductor = Console.ReadLine();
            Console.WriteLine("introduzca la matricula (sigue el formato 0000 XXX)");
            matricula = Console.ReadLine();
            
            if (opt == 1)
            {
                parking[index] = new Coche(marca, modelo, matricula, conductor);
            }
            else if (opt == 2)
            {
                parking[index] = new Moto(marca, modelo, matricula, conductor);
            }
        }
    }
}



