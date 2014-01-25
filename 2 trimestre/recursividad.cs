using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursividad
{
    class Program
    {
        int multiplicaR (int n, int m)
        {
            if (m == 1)
                return n;
            return n + multiplicaR(n, m - 1);
        }
        static void Main(string[] args)
        {
        }
    }
}

/*
int multiplica (int n, int m)
 * int res = 0;
 * for (i=0;i<m;i++)
 *   res = res+n;
 * return res;
*/