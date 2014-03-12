using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ej4
{
	class Dispositivo
	{
		protected int velocidad;
		protected double pantalla;
		protected string tipo;
		protected bool teclado;

		public Dispositivo()
		{ }

		public void SetVelocidad()
		{
			Console.Write("Nueva velocidad: ?");
			velocidad = Convert.ToByte(Console.ReadLine());
		}

		public void SetPantalla()
		{
			Console.Write("nuevo tamaño: ?");
			pantalla = Convert.ToDouble(Console.ReadLine());
		}

		public virtual void MostrarDatos()
		{
			Console.WriteLine("{0}, {1}", velocidad, pantalla);
		}

		public void GetVelocidad()
		{
			Console.WriteLine("Velocidad del procesador" + velocidad);
		}

		public void GetPantalla()
		{
			Console.WriteLine("Tamaño de la pantalla" + pantalla);
		}

		public void GetTipo()
		{
			Console.WriteLine("Tipo de pantalla" + tipo);
		}
	}	
}
