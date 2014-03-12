using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
Create a program which will allow the user to:

1) Enter text at the beginning
2) Enter text at the end
3) Display from beginning to end
4) Display from end to beginning
5) Exit
*/
namespace Contact_witharraylist
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Console.WriteLine( "Second item {0}", myList[1] );
			myList.Insert(1, "Ok?");
			posicion = myList.IndexOf("Hi!");
			myList.Sort();
			myList.RemoveAt(1);
			myList.Remove("Hi!");
			*/

			ArrayList myList = new ArrayList();
			myList.Add("Hi");
			myList.Add("How are you doing?");

			int opcion = 0;
			do
			{
				Console.WriteLine("Introduzca una de las siguientes opciones");
				Console.WriteLine("1) Introducir texto al principio.");
				Console.WriteLine("2) Introducir texto al final");
				Console.WriteLine("3) Mostrar de principio a fin");
				Console.WriteLine("4) Mostrar desde el final al principio");
				Console.WriteLine("5) Sair del programa");

				while (!int.TryParse(Console.ReadLine(), out opcion))
					Console.WriteLine("error, repita la opcion");

				switch (opcion)
				{
					case 1:
						Console.WriteLine("Escriba el texto deseado");
						myList.Insert(0,Console.ReadLine());
						break;

					case 2:
						Console.WriteLine("Escriba el texto deseado");
						myList.Add(Console.ReadLine());
						break;

					case 3:
						foreach (string sentence in myList)
							Console.WriteLine(sentence);
						Console.WriteLine("Pulsa una tecla ...");
						Console.ReadKey();
						break;

					case 4:
						ArrayList myList2 = myList;
						myList2.Reverse();
						foreach (string sentence in myList2)
							Console.WriteLine(sentence);
						myList2.Remove(myList2);
						Console.WriteLine("Pulsa una tecla ...");
						Console.ReadKey();
						break;

					case 5:
						break;
				}

				Console.Clear();
			} while (opcion != 5);

		}
	}
}
