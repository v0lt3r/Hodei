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
        }

        public Vehiculo(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            numRuedas = 5;
            initialSettings(newMarca, newModelo, newMatricula, newConductor);
        }

        protected void initialSettings(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            arrayrueda = new Rueda[numRuedas];
            marca = newMarca;
            modelo = newModelo;
            conductor = newConductor;
            // Comprobacion del input de la matricula
            if (!SetMatricula(newMatricula))
            {
                do
                {
                    Console.WriteLine("Error, vuelva a escribir la matricula del vehiculo!!!!");
                }
                while (!SetMatricula(Console.ReadLine()));
            }
        }

        // ---------marca---------
        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string newMarca)
        {
            marca = newMarca;
        }

        // ---------modelo---------
        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string newModelo)
        {
            modelo = newModelo;
        }

        // ---------matricula---------
        public string GetMatricula()
        {
            return matricula;
        }

        public Boolean SetMatricula(string newMatricula)
        {
            if ( // Condiciones a cumplirse
                newMatricula.Length == 8 &&
                Char.IsDigit(newMatricula[0]) &&
                Char.IsDigit(newMatricula[1]) &&
                Char.IsDigit(newMatricula[2]) &&
                Char.IsDigit(newMatricula[3]) &&
                newMatricula[4] == ' ' &&
                Char.IsLetter(newMatricula[5]) &&
                Char.IsLetter(newMatricula[6]) &&
                Char.IsLetter(newMatricula[7])
                )
            {
                matricula = newMatricula;
                return true; //si se cumplen devolvemos true
            }
            else // en cualquier otro caso, la matricula no es valida
            {
                matricula = "ERROR";
                Console.WriteLine("Revisa la matricula");
                return false;
            }
        }

        // ---------conductor---------
        public string GetConductor()
        {
            return conductor;
        }

        public void SetConductor(string newConductor)
        {
            conductor = newConductor;
        }

        public void cambiaNeumaticos(string marca, string modelo, int radio)
        {
            for (int i = 0; i < numRuedas; i++)
            {
                arrayrueda[i] = new Rueda(radio, marca, modelo);
            }
        }

        public string showRuedas()
        {
            string temp = "";

            for (int i = 0; i < numRuedas; i++)
            {
                temp += "\tRueda" + (i + 1) + ": " + arrayrueda[i].GetMarca() + "| " +
                arrayrueda[i].GetModelo() + "| " +
                arrayrueda[i].GetRadio() + "\n";
            }

            return temp;
        }
    }

}
