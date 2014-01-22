using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcula
{
    public class calcula
    {
        public static int Main(string[] args)
        {
            int primernum = 0;
            int segundonum = 0;


            if (args.Length < 3)
            {
                Console.WriteLine("Escriba 3 parámetros!");
                Environment.Exit(1);
            }
            else if (args[1][0] != '/' && args[1][0] != '*' && args[1][0] != '-' && args[1][0] != '+')
            {
                Console.WriteLine("El segundo parametro introducido no es una operacion válida");
                Environment.Exit(1);
            }
            else if (!(Int32.TryParse(args[0], out primernum) && Int32.TryParse(args[2], out segundonum)))
            {
                Console.WriteLine("El primer o tercer parametro introducido no es un numero");
                Environment.Exit(2);
            }
            else if (args[1][0] == '/' && segundonum == 0)
            {
                Console.WriteLine("error, no se puede dividir por 0");
                Environment.Exit(2);
            }

            if (args[1][0] == '/')
            {
                Console.WriteLine((double)primernum / (double)segundonum);
            }
            else if (args[1][0] == '*')
            {
                Console.WriteLine(primernum * segundonum);
            }
            else if (args[1][0] == '+')
            {
                Console.WriteLine(primernum + segundonum);
            }
            else if (args[1][0] == '-')
            {
                Console.WriteLine(primernum - segundonum);
            }

            return 0;
        }
    }
}


