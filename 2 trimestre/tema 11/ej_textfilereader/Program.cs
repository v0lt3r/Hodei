using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ej_textfilereader
{
	class Program
	{
		static ArrayList myList = new ArrayList();

		static void Main(string[] args)
		{
			StreamReader fichero;
			Console.WriteLine("que fichero deseea leer?");
			string nombre_fichero = Console.ReadLine();
			fichero = File.OpenText(nombre_fichero);
			char tecla = ' ';

			if (fichero != null)
			{
				do{

				
				


				}while(tecla != (char)27);
			}

		}

		static void ReadFile(StreamReader fichero)
		{
			string temp;
			while ((temp = fichero.ReadLine()) != null)
			{
				myList.Add(temp);
			}
			return;
		}

		static void ShowInfo(int inicio)
		{
			Console.WriteLine(inicio + "-" + inicio+20 + "/" + myList.Count);
		}

		static void DisplayForm(int inicio)
		{

		}

	}
}
