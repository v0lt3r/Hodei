using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace arraylist_pares_impares
{
	class Program
	{		

		static void Main(string[] args)
		{
			
			ArrayList arraylist = new ArrayList();
			StreamReader fichero;
			String linea;
			Console.WriteLine("que fichero deseea leer?");
			string nombre_fichero = Console.ReadLine();
			fichero = File.OpenText(nombre_fichero);
			
			while ( (linea = fichero.ReadLine()) != null )
			{
				arraylist.Add(linea);
			} 
			fichero.Close();
			StreamWriter escribe;
			escribe = File.CreateText("output.txt");

			for (int i = 0; i < arraylist.Count; i++)
			{
				if (i%2 != 0) 
				{
					escribe.WriteLine(arraylist[i]);
				}
				else
				{
					Console.WriteLine(arraylist[i]);
				}
			}
			escribe.Close();
		}
	}
}