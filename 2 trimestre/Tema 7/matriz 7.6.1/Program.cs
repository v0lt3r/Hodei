using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz_7._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Primera Matriz"); 
            Matriz m1 = new Matriz();
            m1.creaMatriz();

            Console.WriteLine();
            Console.WriteLine("Segunda Matriz");
            Matriz m2 = new Matriz();
            m2.creaMatriz();

            Matriz m3 = m1 + m2;
            Console.WriteLine();
            Console.WriteLine("Suma de las dos matrices");
            m3.imprimirmatriz();

            Console.WriteLine();
            m1.modificarValor();
            m1.imprimirmatriz();

            Console.WriteLine();
            Console.WriteLine(m2.leerposicion());
            m2.imprimirmatriz();
            Console.WriteLine();

        }
    }
}
