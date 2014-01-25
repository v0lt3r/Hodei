using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumadearray
{
    class Program
    {
        public static void main()
        {

        }
        static void Main(string[] args)
        {
            int[] example = {20,10,5,2};
            int suma = 0;
            for (int i = 0; i < example.Length; i++)
            {
                suma = suma + example[i];
            }
            Console.WriteLine(suma);
        }
    }
}
