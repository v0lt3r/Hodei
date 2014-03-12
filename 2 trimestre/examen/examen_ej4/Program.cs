using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ej4
{
	class Program
	{
		static void Main(string[] args)
		{
			Dispositivo[] midispositivo = new Dispositivo[10];
			char opcion;
			string var;
			int c = 0;
			int velocidad;
			int Nvar;
			double pantalla;

			Console.WriteLine("1) Introducir dispositivo");
			Console.WriteLine("2) Mostrar datos del dispositivo");
			Console.WriteLine("3) Cambiar datos del dispositivo");

			Console.Write("Opcion ");
			opcion = Convert.ToChar(Console.ReadLine());

			switch (opcion)
			{
				case '1':
				if (c == 10)
				{
					Console.WriteLine("Lo sentimos la base de datos esta llena");
				}
				else
				{
					Console.Write("tipo de dispositivo? ");
					var = Console.ReadLine();
					var.ToLower();

					if (var == "tablet")
					{
						Console.Write("velocidad del procesador ? ");
						velocidad = Convert.ToByte(Console.ReadLine());
						Console.Write("tamaño de la pantalla ?");
						pantalla = Convert.ToDouble(Console.ReadLine());
						midispositivo[c] = new Tablet(velocidad, pantalla);
						c++;
					}
					if (var == "smartphone")
					{
						Console.Write("velocidad del procesador ? ");
						velocidad = Convert.ToByte(Console.ReadLine());
						Console.Write("tamaño de la pantalla ?");
						pantalla = Convert.ToDouble(Console.ReadLine());
						midispositivo[c] = new Smartphone(velocidad, pantalla);
						c++;
					}
					if (var == "ordenador")
					{
						Console.Write("velocidad del procesador ? ");
						velocidad = Convert.ToByte(Console.ReadLine());
						Console.Write("tamaño de la pantalla ?");
						pantalla = Convert.ToDouble(Console.ReadLine());
						midispositivo[c] = new Ordenador(velocidad, pantalla);
						c++;
					}
				}

				break;

				case '2':
				Console.Write("numero de dispositivo? ");
				Nvar = Convert.ToByte(Console.ReadLine());

					midispositivo[Nvar-1].MostrarDatos();
				break;

				case '3':
				Console.Write("Introduzca el número de dispositivo: ");
				Nvar = Convert.ToByte(Console.ReadLine());

				if (Nvar > c)
				{
					Console.WriteLine("El dispositivo no existe");
				}

				midispositivo[Nvar-1].SetVelocidad();
				midispositivo[Nvar-1].SetPantalla();
				break;
			}
		}
	}	
}
