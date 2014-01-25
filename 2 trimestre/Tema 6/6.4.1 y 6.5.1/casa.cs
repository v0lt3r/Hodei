using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4._1
{
    class casa
    {
        public casa()
        {
        Puerta = new puerta();
        Ventana = new ventana[9];
        Ventana[0] = new ventana();
        Calefactor = new calefactor[9];
        }
        puerta Puerta;
        ventana []Ventana;
        calefactor[] Calefactor;
         
    }
}
