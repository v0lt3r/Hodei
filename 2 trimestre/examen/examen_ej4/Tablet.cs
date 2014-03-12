using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ej4
{
	class Tablet : Dispositivo
	{
		public Tablet(int newVelocidad, double newPantalla)
		{
			velocidad = newVelocidad;
			pantalla = newPantalla;
			tipo = "Tablet";
			teclado = false;
		}


		public override void MostrarDatos()
		{
			Console.Write("Tablet --->");
			base.MostrarDatos();
		}
	}
}
