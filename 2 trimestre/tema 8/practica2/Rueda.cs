using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Rueda
    {
        protected int radio;
        protected string marca;
        protected string modelo;

        public Rueda()
        {
        }

        public Rueda(int newRadio, string newMarca, string newModelo)
        {
            radio = newRadio;
            marca = newMarca;
            modelo = newModelo;
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

        // ---------radio---------
        public int GetRadio()
        {
            return radio;
        }

        public void SetRadio(int newRadio)
        {
            radio = newRadio;
        }
    }

}
