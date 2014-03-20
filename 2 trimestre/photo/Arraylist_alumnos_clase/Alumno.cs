using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_alumnos_clase
{
    class Alumno
    {
        string _Nombre;
        string _Nif;
        int _Edad;
        int _Numclase;   

        public Alumno()
        {
            _Nombre = "";
            _Nif = "";
            _Edad = -1;
            _Numclase = -1;   
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Nif
        {
            get { return _Nif; }
            set { _Nif = value; }
        }
        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }
        public int Numclase
        {
            get { return _Numclase; }
            set { _Numclase = value; }
        }


    }
}

/*        public void SET_Nombre(string newNombre)
        {
            this._Nombre = newNombre;
        }
*/