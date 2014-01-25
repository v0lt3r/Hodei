using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personanamespace
{
    public class ejercicio
    {
        public static void Main(string[] args)
        {
            Persona p1, p2;
            p1 = new Persona();
            p2 = new Persona();
            p1.SetNombre("carlos");
            p2.SetNombre("juan");
            p1.Saludar();
            p2.Saludar();
        }
    }
}
