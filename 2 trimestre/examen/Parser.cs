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
			try {
				fichero = File.OpenText(nombre_fichero);
				fichero2 = File.CreateText(nombre_fichero.Substring(0, nombre_fichero.Length-4) + ".conv");
			}
			catch(Exception e) { }

			string tokenInsert = "insert into ";
			string linea = " ";
			string linea2 = " ";

			if (fichero != null && fichero2 != null) {
				while ((linea = fichero.ReadLine()) != null)
				{
					if ((linea.IndexOf(tokenInsert) >= 0) && (linea.Substring(0, tokenInsert.Length) == tokenInsert))
					{
						linea2 = comprimirEspacios(linea.Substring(tokenInsert.Length, linea.IndexOf(";") - tokenInsert.Length), '\'');
						if (linea2 != "")
							functInsert(linea2);
					}
				}

				fichero.Close();
				fichero2.Close();
			}
			else {
				Console.WriteLine("Fichero no existente");
			}
		}

		static string comprimirEspacios(string newString, char stringDelimiter)
		{
			StringBuilder nuova = new StringBuilder();
            bool flag = false;

            for (int i = 0; i < newString.Length; i++)
            {
                if (newString[i] == stringDelimiter && (flag == false))
                {
                    nuova.Append(newString[i]);
                    flag = true;
                }
                else if (newString[i] == stringDelimiter && (flag == true))
                {
                    nuova.Append(newString[i]);
                    flag = false;
                }
                else if ((newString[i] == ' ') && (flag == false))
                { }
                else if ((newString[i] == '\t') && (flag == false))
                { }
                else
                {
                    nuova.Append(newString[i]);
                }
            }

            if (flag == true)
            {
                Console.WriteLine("Comillas no cerradas");
                return null;
            }

            return nuova.ToString();
		}

        static int functInsert(string newString)
		{
			string buscar1 = ")value(";
            string buscar2 = "(";
            // string buscar3 = ")";

			int index1 = newString.IndexOf(buscar1);
			if(index1 < 0){
				fichero2.WriteLine("Error no se han indicado los valores");
				fichero2.WriteLine();
				return -1;
			}

			string primeraParte = newString.Substring(0, index1+1);
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
            string camp = primeraParte.Substring(index2);
            string val  = newString.Substring(index1 + buscar1.Length-1);

            string[] campos  = separaPalabras(camp.Substring(1, camp.Length-2), ',', '\'');
            string[] valores = separaPalabras( val.Substring(1,  val.Length-2), ',', '\'');

			if(campos.Length != valores.Length){
				fichero2.WriteLine("Error el numero de campos es diferente desde el numero de valores");
				fichero2.WriteLine();
				return -1;
			}
			else {
				fichero2.WriteLine(nombreBaseDatos);
				for (int i = 0; i < campos.Length; i++)
				{
                    fichero2.WriteLine(campos[i] + ":" + valores[i]);
				}

                fichero2.WriteLine();
				return 1;
			}
		}

		static string[] separaPalabras(string palabras, char delimiter, char stringDelimiter)
		{
			List<string> listPalabras = new List<string>();
            StringBuilder nuova = new StringBuilder();
            bool flag = false;

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] == stringDelimiter && (flag == false))
                {
                    nuova.Append(palabras[i]);
                    flag = true;
                }
                else if (palabras[i] == stringDelimiter && (flag == true))
                {
                    nuova.Append(palabras[i]);
                    flag = false;
                }
                else if ((palabras[i] == delimiter) && (flag == false))
                {
                    listPalabras.Add(nuova.ToString());
                    nuova.Remove(0, nuova.Length);
                }
                else
                {
                    nuova.Append(palabras[i]);
                    if(i == palabras.Length-1)
                        listPalabras.Add(nuova.ToString());
                }
            }

			return listPalabras.ToArray();
		}

		
	}
}

