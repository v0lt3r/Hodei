using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcion_fibonacci
{
    class Program
    {
        public static long fibo(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            return fibo(n - 1) + fibo(n - 2);
        }
        
        public static float fibo2(int n)
        {
            float n1 = 0;
            float n2 = 0;
            float temp = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    n1 = 1;
                    Console.WriteLine(n1);
                }
                else if (i == 1)
                {
                    n2 = 1;
                    Console.WriteLine(n2);
                }
                else
                {
                    Console.WriteLine(n1 + n2);
                    temp = n1;
                    n1 = n2;
                    n2 = n1 + temp;
                }
            }

            return n2;
        }

        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("a que numero de fibonacci debo parar?");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("el numero de fibonacci es {0}", fibo2(num)); 
            }
            else
                Console.WriteLine("error");
        }
    }
}
