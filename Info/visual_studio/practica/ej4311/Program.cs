using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4311
{
    class Program
    {
        struct cancion
        {
          public string artista;
          public string titulo;
          public double duracion;
          public int    tamaño;
        }
        public static void Main(string[] args)
        {
            cancion cancion;

            Console.WriteLine("introduzca la cancion:");
            cancion.artista = Console.ReadLine();

            Console.WriteLine("introduzca el titulo");
            cancion.titulo = Console.ReadLine();

            Console.WriteLine("introduzca la duracion en segundos");
            cancion.duracion = double.Parse(Console.ReadLine());

            Console.WriteLine("introduzca el tamaño");
            cancion.tamaño = int.Parse(Console.ReadLine());
        }
    }
}
