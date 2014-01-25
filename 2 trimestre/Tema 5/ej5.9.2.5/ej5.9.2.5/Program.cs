using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5._9._2._5
{
    class Program
    {
        public struct puntocartesiano 
        {
            public double x;
            public double y;
        }

        public static double distancia (puntocartesiano primero, puntocartesiano segundo)
        {
            return Math.Sqrt(Math.Pow((primero.x - segundo.x), 2) + Math.Pow((primero.y - segundo.y), 2));            
        }
        public static void Main(string[] args)
        {
            puntocartesiano punto1;
            puntocartesiano punto2;

            Console.WriteLine("escriba la X del primer punto");
            punto1.x = Convert.ToDouble(Console.ReadLine());
 
            Console.WriteLine("escriba la Y del primer punto");
            punto1.y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("escriba la X del Segundo punto");
            punto2.x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("escriba la Y del Segundo punto");
            punto2.y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("la distancia entre los 2 puntos es:" + distancia(punto1, punto2));
        }
    }
}
