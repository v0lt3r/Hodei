using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Vehiculo[] parking = new Vehiculo[10];
            int index;

            Moto Replica = new Moto();
            Replica.GetMatricula();
            Replica.cambiaNeumaticos(16, "Michelin", "eco");

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
                        break;

                    case 2:
                        break;

                    case 3:
                        break;


                }

                if (opcion == 6)
                    Console.WriteLine("opcion no valida!");
                else
                    Console.WriteLine("... pulsa una tecla");
                Console.ReadLine();

            } while (opcion != 5);

            
        }
    }
}



            bool flag = false;
            while(flag)
            {
                if (!SetMatricula(newMatricula))
                {
                    Console.WriteLine("Revisa la matricula");
                    flag = false;
                }
                else
                    flag = true;
            }
