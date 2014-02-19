using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Vehiculo
    {
        protected int numRuedas;
        protected string marca;
        protected string modelo;
        protected string matricula;
        protected string conductor;
        protected Rueda[] arrayrueda;
        
        public Vehiculo() 
        {
            numRuedas = 5;
            arrayrueda = new Rueda[numRuedas];
        }

        public Vehiculo(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            marca = newMarca;
            modelo = newModelo;
            conductor = newConductor;
            arrayrueda = new Rueda[numRuedas];

            SetMatricula(newMatricula);
        }

        // marca
        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string newMarca)
        {
            marca = newMarca;
        }

        // modelo
        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string newModelo)
        {
            modelo = newModelo;
        }

        // matricula
        public string GetMatricula()
        {
            return matricula;
        }

        public Boolean SetMatricula(string newMatricula)
        {
            if (
                newMatricula.Length == 7 &&
                Char.IsDigit(newMatricula[0]) &&
                Char.IsDigit(newMatricula[1]) &&
                Char.IsDigit(newMatricula[2]) &&
                Char.IsDigit(newMatricula[3]) &&
                Char.IsLetter(newMatricula[4]) &&
                Char.IsLetter(newMatricula[5]) &&
                Char.IsLetter(newMatricula[6])
            )
            {
                matricula = newMatricula;
                return true;
            }
            else
            {
                matricula = "ERROR";
                Console.WriteLine("Revisa la matricula");
                return false;
            }
        }

        // conductor
        public string GetConductor()
        {
            return conductor;
        }

        public void SetConductor(string newConductor)
        {
            conductor = newConductor;
        }

        public void cambiaNeumaticos(int radio, string marca, string modelo)
        {
            for (int i = 0; i < numRuedas; i++)
			{
                arrayrueda[i] = new Rueda(radio, marca, modelo);	 
			}
        }
    }
}
