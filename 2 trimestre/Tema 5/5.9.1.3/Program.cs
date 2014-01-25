using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] array = new char[24, 79];
            Random r = new Random();
            int x;
            int y;
            for (int i = 0; i < 100; i++)
            {
               x = r.Next(0,23);
               y = r.Next(0,78);
               array[x, y] = '*';
            }
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 79; j++)
			    {
			        Console.Write(array[i,j]);
			    }
                Console.WriteLine();
            }
        }
    }
}
