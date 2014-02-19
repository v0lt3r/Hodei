using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Moto: Vehiculo
    {
        public Moto() 
        {
            numRuedas = 2;
            arrayrueda = new Rueda[numRuedas];
        }

        public Moto(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            marca = newMarca;
            modelo = newModelo;
            matricula = newMatricula;
            conductor = newConductor;
            arrayrueda = new Rueda[numRuedas];
        }  
    }
}
