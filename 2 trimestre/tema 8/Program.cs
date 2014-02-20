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
						// bool flag = false;
						// while(flag)
						// {
							// if (!SetMatricula(newMatricula))
							// {
								// Console.WriteLine("Revisa la matricula");
								// flag = false;
							// }
							// else
								// flag = true;
						// }
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
			// SetMatricula(newMatricula);
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
                Char.IsLetter(newMatricula[4]) &&
                Char.IsLetter(newMatricula[5]) &&
                Char.IsLetter(newMatricula[6])
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

		public void cambiaNeumaticos(int radio, string marca, string modelo)
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
			matricula = newMatricula;
			conductor = newConductor;
			arrayrueda = new Rueda[numRuedas];
		}
	}

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
            matricula = newMatricula;
            conductor = newConductor;
            arrayrueda = new Rueda[numRuedas];
        }  
    }

}



