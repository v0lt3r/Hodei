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
            conductor = newConductor;
            arrayrueda = new Rueda[numRuedas];
            // Comprobacion del input de la matricula
            if (!SetMatricula(newMatricula))
            {
                do
                {
                    Console.WriteLine("Error, vuelva a escribir la matricula del vehiculo!!!!");
                } while (!SetMatricula(Console.ReadLine()));
            }
        }
    }
}
