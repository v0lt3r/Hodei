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
			do
			{
				linea = fichero.ReadLine();
				if (linea.Substring(0, 12) == "insert into ")
				{
					functBaseDatos(linea.Substring(11));
				}
			} while (linea != "");

	
			fichero.Close();
			fichero2.Close();

		}

		static int functBaseDatos(string newString)
		{
			int index = newString.IndexOf(" value ");
			if(index < 0)
			{
				fichero2.WriteLine("Error no se han indicado los valores");
				fichero2.WriteLine();
				return -1;
			}
			
			string primeraParte = newString.Substring(0, index);
			int index2 = primeraParte.IndexOf(" ");
			string nombreBaseDatos = primeraParte.Substring(0, index2);
			bool flag = true;
			for (int i = 0; i < nombreBaseDatos.Length; i++)
			{
				if (!char.IsLetterOrDigit(nombreBaseDatos[i]))
					flag = false;
			}
			if (flag == false)
			{
				fichero2.WriteLine("Error no se ha indicado una base de datos");
				fichero2.WriteLine();
				return -1;
			}
			
			string[] campos  = separaPalabras(primeraParte.Substring(index2 + 1));
			string[] valores = separaPalabras(newString.Substring(index + 7));
			if(campos == null)
			{

			}
			if(valores == null)
			{

			}

			return 1;
		}

		static string[] separaPalabras(string palabras)
		{
			separaComillas(palabras.Substring(0, palabras.IndexOf(";")));
			return null;
		}

		static string[] separaComillas(string cadena)
		{
			string[] array = new string[100];

			int i = 0;
			int index1 = cadena.IndexOf("'");
			int index2;
			while(index1 >= 0)
			{
				index2 = cadena.IndexOf("'", index1 + 1);
				array[i] = cadena.Substring(index1 + 1, index2);
				index1 = cadena.IndexOf("'"); 
				i++;
			}
		}


	}
}

