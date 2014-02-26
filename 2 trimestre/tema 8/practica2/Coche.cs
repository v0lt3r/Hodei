using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Coche : Vehiculo
    {
        public Coche()
        {
            numRuedas = 4;
        }

        public Coche(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            numRuedas = 4;
            initialSettings(newMarca, newModelo, newMatricula, newConductor);
        }
    }

}
