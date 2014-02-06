using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3d [] array = new Point3d[];
            double x;
            double y;
            double z;

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.WriteLine("Escriba el punto X");
                } while (!Double.TryParse(Console.ReadLine(), out x));
                do
                {
                    Console.WriteLine("Escriba el punto Y");
                } while (!Double.TryParse(Console.ReadLine(), out y));
                do
                {
                    Console.WriteLine("Escriba el punto Z");
                } while (!Double.TryParse(Console.ReadLine(), out z));
                array[i] = new Point3d(x, y, z);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("el primer punto es {0}", array[i].ToString());
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("la distancia entre el punto 1 y el punto {0} es: {1}", i, array[1].DistanceTo(array[i]));
            }
        }
    }
}
