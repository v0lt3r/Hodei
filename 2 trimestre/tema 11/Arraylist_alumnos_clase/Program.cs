using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un menu con el que podamos añadir, mostrar, modificar y borrar para alumnos. Y para clase vamos a dar de alta y baja a alumnos y tambien mostrar los alumnos que hay y añadir y borrar una clase. (Serian 2 menus.)
 * Necesitamos esta informacion de alumnos: nombre, nif, edad, clase.
 * De clase necesitamos, el nombre de clase y un codigo de la clase, y los alumnos que hay en la clase.
 * */

namespace Arraylist_alumnos_clase
{
    class Program
    {
        static List<Alumno> _ListaAlumnos;
        static List<Clase> _ListaClase;
        static void Main(string[] args)
        {
            _ListaAlumnos = new List<Alumno>();
            _ListaClase = new List<Clase>();
            int opcion = -1;
            int opcion2 = -1;
            do
            {
                opcion = mostrarMenu();
                //Menu principal
                switch (opcion)
                {
                    //alumnos
                    case 1:
                        do
                        {
                            opcion2 = mostrarMenuAlumnos();
                            //Menu alumnos
                            switch (opcion2)
                            {
                                case 1:
                                    AnyadirAlumno();

                                    break;
                                case 2:


                                    break;
                                case 3:
                                    break;
                                case 4:
                                    break;
                                case 5:

                                    break;
                                default:
                                    break;
                            }
                        } while (opcion2 != 5);
                        break;
                    //clase
                    case 2:
                        do
                        {
                            opcion2 = mostrarMenuClase();
                            //Menu clase
                            switch (opcion2)
                            {
                                case 1:
                                    AnyadirAlumno();

                                    break;
                                case 2:


                                    break;
                                case 3:
                                    break;

                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("error");
                                    break;
                            }
                        } while (opcion2 != 5);
                        break;

                    case 3:
                        opcion = 0;
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            } while (opcion != 0);
        }

        public static int mostrarMenu()
        {
            Console.Clear();
            int opcion;
            Console.WriteLine("1) alumnos");
            Console.WriteLine("2) clase");
            Console.WriteLine("3) salir");

            Console.WriteLine("Escriba la opcion deseada");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            return opcion;
        }

        public static int mostrarMenuAlumnos()
        {
            Console.Clear();
            int opcion;
            Console.WriteLine("1) añadir");
            Console.WriteLine("2) mostrar");
            Console.WriteLine("3) modificar");
            Console.WriteLine("4) borrar");
            Console.WriteLine("5) volver");

            Console.WriteLine("Escriba la opcion deseada");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }
            return opcion;
        }

        public static int mostrarMenuClase()
        {
            Console.Clear();
            int opcion;
            Console.WriteLine("1) Añadir clase");
            Console.WriteLine("2) Borrar clase");
            Console.WriteLine("3) Dar de alta un alumno");
            Console.WriteLine("3) Dar de baja un alumno");
            Console.WriteLine("5) volver");

            Console.WriteLine("Escriba la opcion deseada");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }
            return opcion;
        }

        public static void AnyadirAlumno()
        {
            Alumno A1 = new Alumno();
            Console.WriteLine("Escriba el nombre del alumno");
            string newNombre = Console.ReadLine();
            A1.Nombre = newNombre;

            Console.WriteLine("Escriba el nif del alumno");
            string newNif = Console.ReadLine();
            A1.Nif = newNif;

            Console.WriteLine("Escriba el edad del alumno");
            int NewEdad = -1;
            if (!int.TryParse(Console.ReadLine(), out NewEdad))
                Console.WriteLine("error");
            else
                A1.Edad = NewEdad;
            _ListaAlumnos.Add(A1);
        }
    }
}


/*
 * 
Alumno o = new Alumno();

o.Nombre = "juan"; // = o.SET_Nombre("juan");
string g = o.Nombre; // = o.GET_Nombre();

*/