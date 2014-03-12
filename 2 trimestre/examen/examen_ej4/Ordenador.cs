using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ej4
{
	class Ordenador : Dispositivo
	{

		public Ordenador(int vel, double pant)
		{
			this.velocidad = vel;
			this.pantalla = pant;
			teclado = true;
		}


		public override void MostrarDatos()
		{
			Console.Write("Ordenador,");
			base.MostrarDatos();
		}
	}
}
