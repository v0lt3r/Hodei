using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();
            p1.SetNombre("juan");
            p1.Saludar();
            p2.SetNombre("sofia");
            p2.Saludar();
        }
    }
}
