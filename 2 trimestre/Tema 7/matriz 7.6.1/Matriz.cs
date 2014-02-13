using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz_7._6._1
{
    class Matriz
    {
        static int largo = 3;
        static int ancho = 3;

        int[,] matriz = new int [largo, ancho];

        public Matriz()
        {
            for (int i = 0; i < largo; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    matriz[i, j] = 0;
                }
            }
        }

        public void creaMatriz()
        {
            for (int i = 0; i < largo; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Console.WriteLine("escriba el valor del elemento en la linea {0} y en la columna {1}", i + 1, j + 1);
                    while (!int.TryParse(Console.ReadLine(), out matriz[i, j])) 
                    {
                        Console.WriteLine("Error!");
                        Console.WriteLine("escriba el valor del elemento en la linea {0} y en la columna {1}", i + 1, j + 1);
                    } 
                }
            }
        }

        public void modificarValor()
        {
            int linea;
            int columna;
            int valor;

            Console.WriteLine("escriba la linea del valor a modificar");
            while (!int.TryParse(Console.ReadLine(), out linea) || linea > largo)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("escriba la linea del valor a modificar");
            }

            Console.WriteLine("escriba la columna del valor a modificar");
            while (!int.TryParse(Console.ReadLine(), out columna) || columna > ancho)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("escriba la columna del valor a modificar");
            }

            Console.WriteLine("escriba el valor a modificar"); 
            while (!int.TryParse(Console.ReadLine(), out valor)) 
            {
                Console.WriteLine("Error!");
                Console.WriteLine("escriba el valor a modificar");
            } 

            matriz[(linea-1), (columna-1)] = valor;
        }

        public int leerposicion()
        {
            int linea;
            int columna;

            Console.WriteLine("escriba la linea del valor a leer");
            while (!int.TryParse(Console.ReadLine(), out linea) || linea > largo)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("escriba la linea del valor a leer");
            }

            Console.WriteLine("escriba la columna del valor a leer");
            while (!int.TryParse(Console.ReadLine(), out columna) || columna > ancho)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("escriba la columna del valor a leer");
            }

            return matriz[linea-1, columna-1];
        }

        public void imprimirmatriz()
        {
            for (int i = 0; i < largo; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write("\t" + matriz[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static Matriz operator +(Matriz mat1, Matriz mat2)
        {
            Matriz matriz3 = new Matriz();
            for (int x = 0; x < largo; x++)
			{
			        for (int y = 0; y < ancho; y++)
			        {
                        matriz3.matriz[x, y] = mat1.matriz[x, y] + mat2.matriz[x, y];
			        }
			}
            return matriz3;
        }
    }
}
