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
        static Vehiculo[] parking = new Vehiculo[numVehiculos + 1];
        static int index = 0;

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear(); // Limpiamos lo que hubiese en la consola y mostramos el menu.
                Console.WriteLine("1. Añadir vehiculo");
                Console.WriteLine("2. Listado de vehiculos");
                Console.WriteLine("3. Cambiar neumaticos a un vehiculo");
                Console.WriteLine("4. Dar de baja un vehiculo");
                Console.WriteLine("5. Salir del programa");
                Console.WriteLine();
                if (!int.TryParse(Console.ReadLine(), out opcion)) // Comprobacion de input, si falla la conversion a int (es decir no es un numero), salimos del menu con opcion=6
                    opcion = 6;

                switch (opcion) // Funciones individuales extra por cada case, para mejorar la legibilidad del switch.
                {
                    case 1:
                        AñadeVehiculo();
                        break;
                    case 2:
                        Lista();
                        break;
                    case 3:
                        CambiarNeumaticos();
                        break;
                    case 4:
                        DarBaja();
                        break;
                    case 5:
                        Console.WriteLine("Hasta luego !!!!!!!");
                        break;
                    default:      // Si escribimos otra opcion, saltara el mensaje.
                        Console.WriteLine("opcion no valida!");
                        break;
                }
                Console.WriteLine("... pulsa una tecla para volver al menú");
                Console.ReadKey();
            }
            while (opcion != 5);
        }

        static void introducirDatos(int opt)
        {
            string marca;
            string modelo;
            string conductor;
            string matricula;

            Console.WriteLine("introduzca la marca");
            marca = Console.ReadLine();
            Console.WriteLine("introduzca el modelo");
            modelo = Console.ReadLine();
            Console.WriteLine("introduzca el nombre del conductor");
            conductor = Console.ReadLine();
            Console.WriteLine("introduzca la matricula (sigue el formato 0000 XXX)");
            matricula = Console.ReadLine();

            if (opt == 1)
                parking[index] = new Coche(marca, modelo, matricula, conductor);
            else if (opt == 2)
                parking[index] = new Moto(marca, modelo, matricula, conductor);

            setRuedas(parking[index]);
            index++;
        }

        static void setRuedas(Vehiculo temp)
        {
            string marca;
            string modelo;
            int radio;

            Console.WriteLine("Introduzca la Marca de los neumaticos");
            marca = Console.ReadLine();

            Console.WriteLine("Introduzca el modelo de neumatico");
            modelo = Console.ReadLine();

            Console.WriteLine("Introduzca el radio");
            while (!int.TryParse(Console.ReadLine(), out radio)) // Control de input con tryparse
            {
                Console.WriteLine("Error!!! (Escriba un radio valido)");
                Console.WriteLine("Introduzca el radio");
            }

            temp.cambiaNeumaticos(marca, modelo, radio);
        }

        static bool listaVehiculos()
        {
            if (index == 0)
            {
                Console.WriteLine("parking vacio!");
                return false;
            }

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("Vehiculo " + (i + 1) + "\t" + parking[i].GetMarca() + "\t"
                    + parking[i].GetModelo() + "\t" + parking[i].GetMatricula() + "\t"
                    + parking[i].GetConductor());
                Console.WriteLine(parking[i].showRuedas());
            }

            return true;
        }

        static int comprobacionNumeros(string mensaje, int max)
        {
            int opcion2;

            Console.WriteLine(mensaje);
            while (!int.TryParse(Console.ReadLine(), out opcion2) || (opcion2 < 1 || opcion2 > max))
            {
                Console.WriteLine("Error (escriba un numero entre 1 y " + max + ")");
                Console.WriteLine(mensaje);
            }

            return opcion2;
        }

        static void borraVehiculo(int baja)
        {
            for (int i = (baja - 1); i < index - 1; i++)
            {
                parking[i] = parking[i + 1];
            }

            index--;
        }

        static void AñadeVehiculo()
        {
            Console.Clear();
            if (index == numVehiculos - 1) 
            {
                Console.WriteLine("Lo sentimos, el parking está completo!");
                return;
            }

            introducirDatos(comprobacionNumeros("¿quieres añadir un coche (1) o una moto (2)?", 2));
        }

        static void Lista()
        {
            Console.Clear();
            listaVehiculos();
        }

        static void CambiarNeumaticos()
        {
            Console.Clear();
            if (!listaVehiculos())
                return;
            Console.WriteLine("");
            setRuedas(parking[comprobacionNumeros("¿A que vehiculo quieres cambiar los neumaticos?", index) - 1]);
        }

        static void DarBaja()
        {
            Console.Clear();
            if (!listaVehiculos())
                return;
            Console.WriteLine("");
            borraVehiculo(comprobacionNumeros("¿Que vehiculo quieres dar de baja?", index));
        }
    }
}



