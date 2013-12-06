using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nAcHo
{
    class Program
    {
        static void Main(string[] args)
        {
            string varpalabra = "";
            Console.WriteLine("escriba la palabra que desea modificar en minusculas");
            varpalabra = Console.ReadLine();
            StringBuilder cadenamodificable = new StringBuilder(varpalabra);
            int i = 0;

            while (i < varpalabra.Length)
            {
                if (i % 2 == 1)
                    cadenamodificable[i] = char.ToUpper(cadenamodificable[i]);
                else
                    cadenamodificable[i] = char.ToLower(cadenamodificable[i]);
                i++;
            }
            Console.WriteLine(cadenamodificable);

            /*
           // string[] palabra = new string[500];
            string varpalabra ="";
            char [] tempstring = new char[100];
            Console.WriteLine("escriba la palabra que desea modificar en minusculas");
            varpalabra = Console.ReadLine();
            int i = 0;
            char temp = '\0';
            temp = varpalabra[i];

            while (i < varpalabra.Length)
            {
                temp = varpalabra[i];
                if (i%2 == 1)
                    tempstring[i] = char.ToUpper(temp);
                else
                    tempstring[i] = char.ToLower(temp);
                
                i++;
            }
            Console.WriteLine(tempstring);
            */
        }
    }
}
