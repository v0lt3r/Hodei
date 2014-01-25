using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen01hperez4
{
    class Program
    {
        struct alumno
        {
            public string nombre;
            public string grupo;
            public double nota;
        }

        public static string tempnombre = "";

        static void Main(string[] args)
		{
			alumno[] alumnos = new alumno[10];
			int index = 0;
			string tempgrupo = "";
			double tempnota = 0;

			int i = 0;
			while (index < alumnos.Length && tempnombre != "fin")
			{
				Console.WriteLine("introduzca el nombre del alumno");
				tempnombre = Console.ReadLine();
				while (tempnombre == "")
				{
					Console.WriteLine("Cadena demasiado corta, introduzcala de nuevo: ");
					tempnombre = Console.ReadLine();
				}

				alumnos[i].nombre = tempnombre;
				if (tempnombre != "fin")
				{
					Console.WriteLine("introduzca el grupo del alumno");
					tempgrupo = Console.ReadLine();
					while (tempgrupo == "")
					{
						Console.WriteLine("Cadena demasiado corta, introduzcala de nuevo: ");
						tempgrupo = Console.ReadLine();
					}

					alumnos[i].grupo = tempgrupo;

                   
                    Console.WriteLine("introduzca la nota del alumno");
					

                    while (!double.TryParse(Console.ReadLine(), out tempnota) || tempnota > 10 || tempnota < 0)
                    {
                        Console.WriteLine("Nota incorrecta");
	                }
                    alumnos[i].nota = tempnota;
					i++;
					index++;
				}
			}

			char opcion = '%';

			do
			{
				Console.WriteLine("a. Mostrar la lista de todos los alumnos");
				Console.WriteLine("b. mostrar todos los datos de los alumnos que hayan superado una cierta nota");
				Console.WriteLine("c. Mostrar los datos de alumno cuya incial sea la que el usuario indique");
				Console.WriteLine("d. salir del programa");

				opcion = Convert.ToChar(Console.ReadLine());
                switch (opcion)
				{
					case 'a':
                        for (int j = 0; j < index; j++)
					{
						Console.WriteLine("Alumno:" + alumnos[j].nombre);
					}

					break;

					case 'b':
                        int corte = 0;
					    Console.WriteLine("Cual sera La nota de corte Para mostrar?");
					    int.TryParse(Console.ReadLine(), out corte);
					    for (int j = 0; j < alumnos.Length; j++)
					    {
						    if (alumnos[j].nota > corte)
						    {
							    Console.WriteLine("Alumno:" + alumnos[j].nombre);
							    Console.WriteLine("grupo:" + alumnos[j].grupo);
							    Console.WriteLine("nota:" + alumnos[j].nota);
						    }
					    }

					break;

					case 'c':
                        char inicial;
					    Console.WriteLine("Cual inicial se debe buscar?");
                        inicial = Console.ReadLine().ToLower()[0];

                        for (int k = 0; k < alumnos.Length; k++)
                        {
                            if (alumnos[i].nombre.ToLower()[0] == inicial)
                            {
                                Console.WriteLine("Alumno:" + alumnos[k].nombre);
                            }
                        }
                        
                    break;

                    case 'd':
                        Console.WriteLine("saliendo..");
                    break;

                    default:
                    Console.WriteLine("opcion incorrecta");
                    break;
                }
            } while (opcion !='d');
        }
    }
}