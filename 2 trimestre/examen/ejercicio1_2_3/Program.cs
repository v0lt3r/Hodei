using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ejercicio1_2_3
{
	class Program
	{
		static void Main(string[] args)
		{
			 MayoresEdad("prueba.txt");
		}

		public static void MayoresEdad(string nombreFichero) 
		{
			StreamReader fichero_origen;
			StreamWriter fichero_destino;
			string linea = "";
			fichero_origen = File.OpenText(nombreFichero);
			fichero_destino = File.CreateText("ficherofinal.txt");

			string nombre = "";
			string apellido = "";
			int edad = 0;
			string direccion = "";

			do
			{
				linea = fichero_origen.ReadLine();
				if (linea != null)
				{
					string[] fichero_partido = linea.Split(';');

					nombre = fichero_partido[0];
					apellido = fichero_partido[1];
					edad = Convert.ToInt32(fichero_partido[2]);
					direccion = fichero_partido[3];

					if (edad >= 18)
					{
						fichero_destino.WriteLine("Nombre: " + nombre);
						fichero_destino.WriteLine("Apellido: " + apellido);
						fichero_destino.WriteLine();
					}
				}

			} while (linea != null);
			fichero_origen.Close();
			fichero_destino.Close();
		}
	}
}
