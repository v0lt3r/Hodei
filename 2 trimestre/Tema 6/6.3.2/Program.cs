using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using personanamespace;

namespace personanamespace
{
    public class ejercicio
    {
        public static void Main(string[] args)
        {
            Persona p1, p2;
            PersonaInglesa p3;
            p1 = new Persona();
            p2 = new Persona();
            p3 = new PersonaInglesa();
            p1.SetNombre("carlos");
            p2.SetNombre("juan");
            p1.Saludar();
            p2.Saludar();
            p3.SetNombre("dan");
            p3.Saludar();
            p3.TomarTe();
        }
    }
}
