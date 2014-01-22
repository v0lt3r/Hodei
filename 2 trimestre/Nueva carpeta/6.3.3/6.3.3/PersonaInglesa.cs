using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personanamespace
{
    class PersonaInglesa:Persona
    {
        public void TomarTe() 
        { 
            Console.WriteLine("estoy tomando te");
        }
        public void Saludar()
        {
            Console.WriteLine("hello I am " + Nombre);
        }
    }
}
