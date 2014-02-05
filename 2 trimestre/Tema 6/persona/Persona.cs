using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    class Persona
    {
        string nombre;
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void Saludar()
        {
            Console.WriteLine("hola soy {0}", this.nombre);
        }
    }
}
