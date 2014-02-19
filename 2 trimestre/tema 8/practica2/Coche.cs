using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Coche: Vehiculo
    {
        public Coche() 
        {
            numRuedas = 4;
            arrayrueda = new Rueda[numRuedas];
        }

        public Coche(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            marca = newMarca;
            modelo = newModelo;
            matricula = newMatricula;
            conductor = newConductor;
            arrayrueda = new Rueda[numRuedas];
        }
    }
}
