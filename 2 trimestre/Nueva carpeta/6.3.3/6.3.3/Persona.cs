using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personanamespace
{
    class Persona
    {
            protected string Nombre;
            public void SetNombre(string nombre)
            {
                Nombre = nombre;
            }

            public void Saludar()
            {
                Console.WriteLine("hola soy " + Nombre);
            }
    }
}
