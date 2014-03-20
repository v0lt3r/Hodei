using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Arraylist_alumnos_clase
{
    class Clase
    {
        string _Nombre;
        int _Codigo;
        List<Alumno> _ListaAlumnos;

        public Clase()
        {
            this._Nombre = "";
            this._Codigo = -1;
            _ListaAlumnos = new List<Alumno>();
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public List<Alumno> ListaAlumnos
        {
            get { return _ListaAlumnos; }
            set { _ListaAlumnos = value; }
        }
    }
}
