using System;
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
			Console.WriteLine("5.- Buscar un fragmento");
			Console.WriteLine("6.- Borrar un dato");
			Console.WriteLine("7.- Modificar un dato");
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
					tempnombre = Console.ReadLine();
					while (tempnombre == "")
					{
						Console.WriteLine("Cadena demasiado corta, introduzcala de nuevo: ");
						tempnombre = Console.ReadLine();
					}

					fichas[numeroFichas].nombreFich = tempnombre;
					int temptamanyo;
					Console.WriteLine("Introduce el tamaño en KB: ");
					while ((!int.TryParse(Console.ReadLine(), out temptamanyo) || temptamanyo < 0))
					{
						Console.WriteLine("El tamaño no puede ser negativo: ");
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
				bool flag = false;
				for (i = 0; i < numeroFichas; i++) {
					if (fichas[i].tamanyo >= tamanyoBuscar) {
						Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
						flag = true;
					}
				}

				if (flag == false)
					Console.WriteLine("No se encontró ningún fichero con las características especificadas.");
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
				for (i = 0; i < numeroFichas; i++)
				{
					if (fichas[i].nombreFich == datoborrar)
					{
						indice = i;
						i = numeroFichas;
					}
				}

				if (indice >= 0)
				{
					for (i = indice + 1; i < numeroFichas; i++)
					{
						fichas[i-1] = fichas[i];
					}

					numeroFichas--;
				}

				break;
				case 7:
				int indice2 = 0;
				Console.WriteLine("Esciba el numero del dato a modificar:");
				if ((int.TryParse(Console.ReadLine(), out indice2) && indice2 > 0 && indice2 <= numeroFichas))
				{
					indice2--;
					Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[indice2].nombreFich, fichas[indice2].tamanyo);

					string tempnombre = "";
					Console.WriteLine("Introduce el nuevo nombre del fichero: ");
					tempnombre = Console.ReadLine();
					if(tempnombre != "")
					{
						fichas[indice2].nombreFich = tempnombre;
					}

					string tempstring;
					int temptamanyo;
					Console.WriteLine("Introduce el nuevo tamaño en KB: ");
					tempstring = Console.ReadLine();
					while ( (!int.TryParse(tempstring, out temptamanyo) || temptamanyo < 0) && tempstring != "")
					{
						Console.WriteLine("El tamaño no puede ser negativo: ");
						tempstring = Console.ReadLine();
					}
					if(tempstring != "")
					{
						fichas[indice2].tamanyo = temptamanyo;
					}
				}
				else
					Console.WriteLine("El dato introducido no es valido");
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