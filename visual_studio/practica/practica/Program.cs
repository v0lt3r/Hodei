using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c = System.Console;

namespace practica
{
    public class practica
    {
        public static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            char operacion;

            string salir = "";
            
            while (!(salir == "fin"))
            {
                // Peticion de datos
               // Console.WriteLine();
                Console.WriteLine("Introduzca el numero 1");
                salir = Console.ReadLine();
                if (salir == "fin")
                {
                    num1 = double.Parse(salir);
                }
                Console.WriteLine("Introduzca la operacion");
                string temp = Console.ReadLine(); // Control de input
                operacion = temp[0];

                if ((operacion != 'R') && (operacion != 'F') && (operacion != 'A'))
                {
                    Console.WriteLine("Introduzca el numero 2");
                    num2 = double.Parse(Console.ReadLine());
                }
                Console.WriteLine(); 
                Console.WriteLine("Resultado:");
                Console.WriteLine();                      
                // calculo de operaciones

                switch (operacion)
                {
                    case '+':
                        c.WriteLine(num1 + num2);
                        break;

                    case '-':
                        c.WriteLine(num1 - num2);
                        break;

                    case '*':
                        c.WriteLine(num1 * num2);
                        break;

                    case '/':
                        c.WriteLine(num1 / num2);
                        break;

                    case 'P':
                        int i = 0;
                        while(i<(int)num2-1)
                        {
                            num1 = num1*num1;
                            i++;
                        }
                        c.WriteLine(num1);
                        break;

                    case 'R':
                        num1 = Math.Sqrt(num1);
                        c.WriteLine(num1);
                        break;

                    case 'A':
                        if (num1 < 0)
                        {
                            num1 = num1 * (-1);
                        }
                        c.WriteLine(num1);
                        break;

                    case 'F':
                        int temp3 = (int) num1;
                        for (int k = (int)num1-1; k > 0; k--)
                        {
                            temp3 = temp3 * k;
                        }
                        c.WriteLine (temp3);
                        break;

                    default:
                        break;

                }
                Console.WriteLine(); 
            }    
        }
    }
}
