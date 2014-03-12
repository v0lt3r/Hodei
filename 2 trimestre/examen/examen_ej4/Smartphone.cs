using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ej4
{
	class Smartphone: Dispositivo
	{
		public Smartphone(int newVelocidad, double newPantalla)
		{
			this.velocidad = newVelocidad;
			this.pantalla = newPantalla;
			this.tipo = "Smartphone";
			teclado = false;
		}


		public override void MostrarDatos()
		{
			Console.Write("Smartphone,");
			base.MostrarDatos();
		}
	}
}
