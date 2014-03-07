using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_tema8_ej1
{
	class Program
	{
		static StreamReader fichero;
		static StreamWriter fichero2;

		static void Main(string[] args)
		{
			Console.WriteLine("Escriba el nombre del fichero a analizar");
			string nombre_fichero = Console.ReadLine();
			fichero = File.OpenText(nombre_fichero);
			fichero2 = File.CreateText("fichero2.txt");

			string linea;
			string linea2;
			do
			{
				linea = fichero.ReadLine();
				if (linea.Substring(0, 12) == "insert into ")
				{
					linea2 = comprimirEspacios(0, linea.Substring(11, linea.IndexOf(";")-11));
					if (linea2 != "")
						functBaseDatos(linea2);
				}
			}
			while (linea != "");

			fichero.Close();
			fichero2.Close();
		}

		static string comprimirEspacios(int index, string newString)
		{
			int i01 = newString.IndexOf("'", index);
			int i02 = 0;
			if (i01 >= 0) {
				i02 = newString.IndexOf("'", i01);
				if (i02 >= 0) {
					Console.WriteLine("Comillas no cerradas");
					return null;
				}
			}

			int i1 = newString.IndexOf(" ", index);
			int i2 = newString.IndexOf("/t", index);

			if(i1 >= 0 && i1 < i01)
				return comprimirEspacios(i1, newString.Substring(0, i1) + newString.Substring(i1+1));
			else if(i2 >= 0 && i2 < i01)
					return comprimirEspacios(i2, newString.Substring(0, i1) + newString.Substring(i1+1));
			else if(i1 >= 0 && i1 > i02)
						return comprimirEspacios(i1, newString);
			else if(i2 >= 0 && i2 > i02)
							return comprimirEspacios(i2, newString);
			else
				return newString;
		}

		static int functBaseDatos(string newString)
		{
			string buscar1 = ")value(";
			string buscar2 = "(";

			int index1 = newString.IndexOf(buscar1);
			if(index1 < 0)
			{
				fichero2.WriteLine("Error no se han indicado los valores");
				fichero2.WriteLine();
				return -1;
			}

			string primeraParte = newString.Substring(0, index1);
			int index2 = primeraParte.IndexOf(buscar2);
			string nombreBaseDatos = primeraParte.Substring(0, index2);
			// bool flag = true;
			// for (int i = 0; i < nombreBaseDatos.Length; i++)
			// {
			// if (!char.IsLetterOrDigit(nombreBaseDatos[i]))
			// flag = false;
			// }

			// if (flag == false)
			// {
			// fichero2.WriteLine("Error no se ha indicado una base de datos");
			// fichero2.WriteLine();
			// return -1;
			// }

			string[] campos = separaPalabras(primeraParte.Substring(index2 + buscar2.Length));
			string[] valores = separaPalabras(newString.Substring(index1 + buscar1.Length));
			if(campos.Length != valores.Length)
			{
				fichero2.WriteLine("Error el numero de campos es diferente desde el numero de valores");
				fichero2.WriteLine();
				return -1;
			}
			else {
				Console.WriteLine(nombreBaseDatos);
				for (int i = 0; i < campos.Length; i++)
				{
					Console.WriteLine(campos[i] + ":" + valores[i]);
				}

				Console.WriteLine();
				return 1;
			}

			return 1;
		}

		static string[] separaPalabras(string palabras)
		{
			List<string> listPalabras = new List<string>();
			int i1 = palabras.IndexOf(",");
			int i01 = palabras.IndexOf("'");
			int i02 = 0;
			if (i01 >= 0) {
				i02 = palabras.IndexOf("'", i01);
				if (i02 >= 0) {
					Console.WriteLine("Comillas no cerradas");
					return null;
				}
			}

			if(i1 >= 0 && i1 < i01) {
				string[] result = separaPalabras(palabras.Substring(i1+1));
				listPalabras.Add(palabras.Substring(0, i1));
				for (int i = 0; i < result.Length; i++)
					listPalabras.Add(result[i]);
				return listPalabras.ToArray();
			}
			else if(i1 >= 0 && i1 > i02) {
				string[] result = separaPalabras(palabras.Substring(i02+1));
				listPalabras.Add(palabras.Substring(0, i01) + palabras.Substring(i01+1, i02-1));
				for (int i = 0; i < result.Length; i++)
					listPalabras.Add(result[i]);
				return listPalabras.ToArray();
			}
			else {
				listPalabras.Add(palabras);
				return listPalabras.ToArray();
			}
		}

		
	}
}

