using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("0.- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            /* Hacemos una cosa u otra según la opción escogida */
            switch (opcion)
            {
                case 1: /* Añadir un dato nuevo */
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

                        fichas[numeroFichas].nombreFich = tempnombre;
                        int temptamanyo;
                        Console.WriteLine("Introduce el tamaño en KB: ");
                        while ((!int.TryParse(Console.ReadLine(), out temptamanyo) || temptamanyo < 0 || temptamanyo > 8000000000))
                        {
                            Console.WriteLine("El tamaño no puede ser negativo o mayor de 8000000000: ");
                        }
                        fichas[numeroFichas].tamanyo = temptamanyo;
                        /* Y ya tenemos una ficha más */
                        numeroFichas++;
                    }
                    else /* Si no hay hueco para más fichas, avisamos */
                        Console.WriteLine("Máximo de fichas alcanzado (1000)!");
                    break;

                case 2: /* Mostrar todos */
                    for (i = 0; i < numeroFichas; i++)
                        Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
                    break;

                case 3: /* Mostrar según el tamaño */
                    Console.WriteLine("¿A partir de que tamaño quieres que te muestre?");
                    tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
                    for (i = 0; i < numeroFichas; i++)
                        if (fichas[i].tamanyo >= tamanyoBuscar)
                            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
                    break;

                case 4: /* Ver todos los datos (pocos) de un fichero */
                    Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
                    textoBuscar = Console.ReadLine();
                    for (i = 0; i < numeroFichas; i++)
                        if (fichas[i].nombreFich == textoBuscar) Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
                    break;

                case 5: // buscar un fragmento
                    string textobuscar = "";
                    string nombremin = "";
                    Console.WriteLine("escriba un fragmento del texto a buscar: ");
                    textobuscar = Console.ReadLine();
                    textobuscar = textobuscar.ToLower();
                    for (i = 0; i < numeroFichas; i++)
                    {
                        nombremin = fichas[i].nombreFich.ToLower();
                        if (nombremin.Contains(textobuscar))
                            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
                    }
                    break;
                case 6: //borrar un dato
                    string datoborrar = "";
                    int indice = -1;
                    Console.WriteLine("escriba el dato a borrar: ");
                    datoborrar = Console.ReadLine();
                    for (i = 0; i < numeroFichas && indice == -1 ; i++) //si indice es -1 es que no lo ha encontrado y no ha llegado al final, entonces sigo buscando.
                    {
                        if (fichas[i].nombreFich == datoborrar)
                        {
                            indice = i;          
                        }
                    }
                    if (indice >= 0)
                    {
                        for (i = indice; i < numeroFichas; i++)
                        {
                            fichas[i] = fichas[i+1];
                        }
                        numeroFichas--;
                    }
                    break;
                case 7:
                    string datoborrar2 = "";
                    int indice2 = -1;

                    Console.WriteLine("escriba el indice del dato a borrar: ");
                    int.TryParse(Console.ReadLine(), out indice2);
                    if (numeroFichas < indice2 || indice2 < 0)
                    {
                        Console.WriteLine("error, el indice no existe");
                    }
                    else
                    {
                        Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[indice2].nombreFich, fichas[indice2].tamanyo);
                        string nombreaux = "";
                        string tamanyoaux = "";
                        Console.WriteLine("escriba el nuevo nombre del fichero");
                        nombreaux = Console.ReadLine();
                        if (nombreaux != "")
                        {
                            fichas[indice2].nombreFich = nombreaux;
                        }
                        Console.WriteLine("escriba el nuevo tamaño del fichero");
                        tamanyoaux = Console.ReadLine();            
                        if (tamanyoaux != "")
                        {
                            fichas[indice2].tamanyo = Convert.ToInt32(tamanyoaux);
                        }
                    }            
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