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
			const int numVehiculos = 10;
			int opcion;
			int opcion2;
			Vehiculo[] parking = new Vehiculo[numVehiculos];
			int index = 0;

			string marca;
			string modelo;
			string conductor;
			int radio;

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
							Console.WriteLine("Parking completo");
							break;
						}

						Console.WriteLine("Quieres anadir un coche (1) o una moto (2)?");
						while(!int.TryParse(Console.ReadLine(), out opcion2) || (opcion2 < 1 && opcion2 > 2))
						{
							Console.WriteLine("Error!!! (Escriba 1 o 2)");
							Console.WriteLine("Quieres anadir un coche (1) o una moto (2)?");
						}

						if(opcion2 == 1)
						{
							parking[index] = new Coche();
							// comune
							Console.WriteLine("Introduzca la Marca");
							marca = Console.ReadLine();
							Console.WriteLine("Introduzca el modelo");
							modelo = Console.ReadLine();
							Console.WriteLine("Introduzca el nombre del conductor");
							conductor = Console.ReadLine();
							Console.WriteLine("Introduzca la matricula (0000 XXX)");
							parking[index] = new Coche(marca, modelo, Console.ReadLine(), conductor);
							Console.WriteLine("Introduzca la Marca de los neumaticos");
							marca = Console.ReadLine();
							Console.WriteLine("Introduzca el modelo de neumatico");
							modelo = Console.ReadLine();
							Console.WriteLine("Introduzca el radio");
							while(!int.TryParse(Console.ReadLine(), out radio))
							{
								Console.WriteLine("Error!!! (Escriba un radio valido)");
								Console.WriteLine("Introduzca el radio");
							}
							parking[index].cambiaNeumaticos(marca, modelo, radio);
							index++;
						}
						else if(opcion2 == 2)
						{
							parking[index] = new Moto();
							// comune
								Console.WriteLine("Introduzca la Marca");
							marca = Console.ReadLine();
							Console.WriteLine("Introduzca el modelo");
							modelo = Console.ReadLine();
							Console.WriteLine("Introduzca el nombre del conductor");
							conductor = Console.ReadLine();
							Console.WriteLine("Introduzca la matricula (NNNN XXX)");
							parking[index] = new Moto(marca, modelo, Console.ReadLine(), conductor);
							Console.WriteLine("Introduzca la Marca de los neumaticos");
							marca = Console.ReadLine();
							Console.WriteLine("Introduzca el modelo de neumatico");
							modelo = Console.ReadLine();
							Console.WriteLine("Introduzca el radio");
							while(!int.TryParse(Console.ReadLine(), out radio))
							{
								Console.WriteLine("Error!!! (Escriba un radio valido)");
								Console.WriteLine("Introduzca el radio");
							}
							parking[index].cambiaNeumaticos(marca, modelo, radio);
							index++;
						}

					break;

					case 2:
					break;

					case 3:
					break;

					case 4:
					break;

					case 5:
						Console.WriteLine("Hasta luego.");
					break;

					default:
					break;
				}

				if (opcion == 6)
					Console.WriteLine("opcion no valida!");
				else
					Console.WriteLine("... pulsa una tecla");
				Console.ReadLine();
			}
			while (opcion != 5);
		}
	}

////////////////////////////////////////////////////////////////////////////////////////////

	class Rueda
	{
		protected int radio;
		protected string marca;
		protected string modelo;

		public Rueda()
		{
		}

		public Rueda(int newRadio, string newMarca, string newModelo)
		{
			radio = newRadio;
			marca = newMarca;
			modelo = newModelo;
		}

		// marca
        public string GetMarca()
		{
			return marca;
		}

		public void SetMarca(string newMarca)
		{
			marca = newMarca;
		}

		// modelo
        public string GetModelo()
		{
			return modelo;
		}

		public void SetModelo(string newModelo)
		{
			modelo = newModelo;
		}

		// radio
        public int GetRadio()
		{
			return radio;
		}

		public void SetRadio(int newRadio)
		{
			radio = newRadio;
		}
	}

////////////////////////////////////////////////////////////////////////////////////////////

    class Vehiculo
	{
		protected int numRuedas;
		protected string marca;
		protected string modelo;
		protected string matricula;
		protected string conductor;
		protected Rueda[] arrayrueda;

		public Vehiculo()
		{
			numRuedas = 5;
			arrayrueda = new Rueda[numRuedas];
		}

		public Vehiculo(string newMarca, string newModelo, string newMatricula, string newConductor)
		{
			marca = newMarca;
			modelo = newModelo;
			conductor = newConductor;
			arrayrueda = new Rueda[numRuedas];
			// comprobacion de matricula *********
			if(!SetMatricula(newMatricula))
			{
				do {
					Console.WriteLine("Vuelve a escribir la matricula del vehículo");
				}
				while(!SetMatricula(Console.ReadLine()));
			}
		}

		// marca
        public string GetMarca()
		{
			return marca;
		}

		public void SetMarca(string newMarca)
		{
			marca = newMarca;
		}

		// modelo
        public string GetModelo()
		{
			return modelo;
		}

		public void SetModelo(string newModelo)
		{
			modelo = newModelo;
		}

		// matricula
        public string GetMatricula()
		{
			return matricula;
		}

		// comprobacion de matricula *********
		public Boolean SetMatricula(string newMatricula)
		{
			if (
                newMatricula.Length == 7 &&
                Char.IsDigit(newMatricula[0]) &&
                Char.IsDigit(newMatricula[1]) &&
                Char.IsDigit(newMatricula[2]) &&
                Char.IsDigit(newMatricula[3]) &&
				newMatricula[4] != ' ' &&
                Char.IsLetter(newMatricula[5]) &&
                Char.IsLetter(newMatricula[6]) &&
                Char.IsLetter(newMatricula[7])
          )
			{
				matricula = newMatricula;
				return true;
			}
			else
			{
				matricula = "ERROR";
				Console.WriteLine("Revisa la matricula");
				return false;
			}
		}

		// conductor
        public string GetConductor()
		{
			return conductor;
		}

		public void SetConductor(string newConductor)
		{
			conductor = newConductor;
		}

		public void cambiaNeumaticos(string marca, string modelo, int radio)
		{
			for (int i = 0; i < numRuedas; i++)
			{
				arrayrueda[i] = new Rueda(radio, marca, modelo);
			}
		}
	}

////////////////////////////////////////////////////////////////////////////////////////////

    class Coche: Vehiculo
	{
		public Coche()
		{
			numRuedas = 4;
			arrayrueda = new Rueda[numRuedas];
		}

		public Coche(string newMarca, string newModelo, string newMatricula, string newConductor)
		{
			marca = newMarca;
			modelo = newModelo;
			conductor = newConductor;
			arrayrueda = new Rueda[numRuedas];
			// comprobacion de matricula *********
			if(!SetMatricula(newMatricula))
			{
				do {
					Console.WriteLine("Vuelve a escribir la matricula del vehículo");
				}while(!SetMatricula(Console.ReadLine()));
			}

		}
	}

////////////////////////////////////////////////////////////////////////////////////////////

    class Moto: Vehiculo
    {
        public Moto() 
        {
            numRuedas = 2;
            arrayrueda = new Rueda[numRuedas];
        }

        public Moto(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            marca = newMarca;
            modelo = newModelo;
            conductor = newConductor;
            arrayrueda = new Rueda[numRuedas];
			// comprobacion de matricula *********
			if(!SetMatricula(newMatricula))
			{
				do {
					Console.WriteLine("Vuelve a escribir la matricula del vehículo");
				}while(!SetMatricula(Console.ReadLine()));
			}
        }  
    }

}



