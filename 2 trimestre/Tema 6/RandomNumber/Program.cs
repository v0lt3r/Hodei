using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    public class RandomNumber
    {
        float seed = 1;
        float m = 233280;
        float a = 9301;
        float c = 49297;

        public float GetFloat ()
        {
            seed = (seed * a + c) % m;           
            return Math.Abs(seed / m);
        }

        public int GetInt (int max)
        {
            return (int)((max * GetFloat())+0.5);
        }

        public int GetInt (int min, int max)
        {
            return GetInt(max - min)+min;
        }
    }

    class Program
    {
            static void Main(string[] args)
            {
                RandomNumber r = new RandomNumber();
                int max = 12;
                int min = 3;

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Numero aleatorio decimal {0}", r.GetFloat());
                    Console.WriteLine("Numero aleatorio entero max {0}: {1}", max, r.GetInt(max));
                    Console.WriteLine("Numero aleatorio entero min {0} max {1}: {2}", min , max, r.GetInt(min, max));
                    Console.WriteLine();
                }
            }
    }
}
