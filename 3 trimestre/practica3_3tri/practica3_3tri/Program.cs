using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Ejemplo46
{
    struct tipoFicha
    {
        public string nombreFich; /* Nombre del fichero */
        public long tamanyo; /* El tamaño en KB */
    };
    public static void Main()
    {
        tipoFicha[] fichas /* Los datos en si */ = new tipoFicha[1000];
        int numeroFichas = 0; /* Número de fichas que ya tenemos */
        int i; /* Para bucles */ int opcion; /* La opcion del menu que elija el usuario */
        string textoBuscar; /* Para cuando preguntemos al usuario */
        long tamanyoBuscar; /* Para buscar por tamaño */
        if (!File.Exists("prueba.txt"))
        {
            File.CreateText("prueba.txt");
        }
		//File.CreateText("prueba2.txt");
        StreamWriter fichero;
        string linea = "";
        StreamReader fichero_origen;

        do
        {
            /* Menu principal */
            Console.WriteLine();
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("1.- Añadir datos de un nuevo fichero");
            Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
            Console.WriteLine("3.- Mostrar ficheros que sean de mas de un cierto tamaño");
            Console.WriteLine("4.- Ver datos de un fichero");
            Console.WriteLine("5.- buscar un fragmento de un fichero");
            Console.WriteLine("6.- borrar un dato");
            Console.WriteLine("7.- modificar un dato por su indice");
            Console.WriteLine("0.- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            /* Hacemos una cosa u otra según la opción escogida */
            switch (opcion)
            {
                case 1: /* Añadir un dato nuevo */
                    
                    fichero_origen = File.OpenText("prueba.txt");
                    numeroFichas = 0;
                    do
                    {
                        linea = fichero_origen.ReadLine();
                        if (linea != null)
                        {                      
                            numeroFichas++;
                        }

                    } while (linea != null);
                    fichero_origen.Close();

                    if (numeroFichas < 1000)
                    {
                        /* Si queda hueco */
                        string tempnombre = "";
                        Console.WriteLine("Introduce el nombre del fichero: ");
                        do
                        {
                            tempnombre = Console.ReadLine();
                            if(tempnombre == "")
                            Console.WriteLine("Cadena demasiado corta, introduzcala de nuevo: ");                     
                        } while (tempnombre == "");

                        
                        int temptamanyo;
                        Console.WriteLine("Introduce el tamaño en KB: ");
                        while ((!int.TryParse(Console.ReadLine(), out temptamanyo) || temptamanyo < 0 || temptamanyo > 8000000000))
                        {
                            Console.WriteLine("El tamaño no puede ser negativo o mayor de 8000000000: ");
                        }

                        fichero = File.AppendText("prueba.txt");
                        fichero.WriteLine("\n"+tempnombre + ";" + temptamanyo);
                        fichero.Close();
                        /* Y ya tenemos una ficha más */
                    }
                    else /* Si no hay hueco para más fichas, avisamos */
                        Console.WriteLine("Máximo de fichas alcanzado (1000)!");
                    break;

                case 2: /* Mostrar todos */
                    fichero_origen = File.OpenText("prueba.txt");
                    do
                    {
                        linea = fichero_origen.ReadLine();
                        if (linea != null && linea != "")
                        {                      
                            Console.WriteLine("Nombre: {0} Tamaño: {1} KB", linea.Split(';')[0], linea.Split(';')[1]);
                        }

                    } while (linea != null);
                    fichero_origen.Close();                                           
                    break;

                case 3: /* Mostrar según el tamaño */
                    fichero_origen = File.OpenText("prueba.txt");
                    Console.WriteLine("¿A partir de que tamaño quieres que te muestre?");
                    tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
                 
                    do
                    {
                        linea = fichero_origen.ReadLine();
                        if (linea != null && linea != "")
                        {
                            if (Convert.ToInt32(linea.Split(';')[1]) >= tamanyoBuscar)
                            Console.WriteLine("Nombre: {0} Tamaño: {1} KB", linea.Split(';')[0], linea.Split(';')[1]);
                        }

                    } while (linea != null);
                    fichero_origen.Close();                                           
                    break;

                case 4: /* Ver todos los datos (pocos) de un fichero */

                    fichero_origen = File.OpenText("prueba.txt");
                    Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
                    textoBuscar = Console.ReadLine();
                    do
                    {
                        linea = fichero_origen.ReadLine();
                        if (linea != null && linea != "")
                        {   
                            if (textoBuscar == linea.Split(';')[0])
                            Console.WriteLine("Nombre: {0} Tamaño: {1} KB", linea.Split(';')[0], linea.Split(';')[1]);
                        }

                    } while (linea != null);
                    fichero_origen.Close();                                          
                    break;

                case 5: // buscar un fragmento
					
                    fichero_origen = File.OpenText("prueba.txt");
                    Console.WriteLine("¿Por que fragmento deseas buscar?");
                    textoBuscar = Console.ReadLine().ToLower();
                    do
                    {
                        linea = fichero_origen.ReadLine();
                        if (linea != null && linea != "")
                        {   
                            if (linea.Split(';')[0].Contains(textoBuscar))
                            Console.WriteLine("Nombre: {0} Tamaño: {1} KB", linea.Split(';')[0], linea.Split(';')[1]);
                        }
                    } while (linea != null);
                    fichero_origen.Close();                                          
                    break;

                case 6: //borrar un dato

                    fichero_origen = File.OpenText("prueba.txt");
					List<string> lista = File.ReadAllLines("prueba.txt").ToList();
                    fichero_origen.Close();
                    Console.WriteLine("¿que texto deseas borrar?");
                    textoBuscar = Console.ReadLine().ToLower();

                    fichero = File.CreateText("prueba.txt");

                    foreach (string dato in lista)
                    {
                        if (dato.Split(';')[0] != textoBuscar)
                            fichero.WriteLine(dato);
                    }

                    fichero.Close();
                              
                    break;

                case 7: // modificar un dato por su indice

                    int indice = 0;
                    string nombreaux = "";
                    Console.WriteLine("Que indice desea borrar?");
                    int.TryParse(Console.ReadLine(), out indice);

                    fichero_origen = File.OpenText("prueba.txt");
					List<string> lista2 = File.ReadAllLines("prueba.txt").ToList();
                    fichero_origen.Close();

                    if (indice < lista2.Count)
                    {
                        fichero = File.CreateText("prueba.txt");
                        for (int k = 0; k < lista2.Count; k++)
                        {
                            if (indice == k + 1)
                            {
                                Console.WriteLine(lista2[k].Split(';')[0]);
                                Console.WriteLine("escriba el nuevo nombre:");
                                nombreaux = Console.ReadLine();
                                if (nombreaux != "")
                                {
                                    lista2[k] = nombreaux + ";" + lista2[k].Split(';')[1];
                                }
                            }

                            fichero.WriteLine(lista2[k]);
                        }

                        fichero.Close();
                    }
                    else
                        Console.WriteLine("el indice no existe");

                    

                    break;
                case 0: /* Salir: avisamos de que salimos */
                    Console.WriteLine("Fin del programa");
                    break;
                default: /* Otra opcion: no válida */
                    Console.WriteLine("Opción desconocida!");
                    break;
            }
        } while (opcion != 0); /* Si la opcion es 5, terminamos */
    }
}