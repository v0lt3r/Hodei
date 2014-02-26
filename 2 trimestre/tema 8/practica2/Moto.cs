using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Moto : Vehiculo
    {
        public Moto()
        {
            numRuedas = 2;
        }

        public Moto(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            numRuedas = 2;
            initialSettings(newMarca, newModelo, newMatricula, newConductor);
        }
    }
}
