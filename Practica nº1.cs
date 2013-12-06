using System;
using c = System.Console;

namespace practica
{
    public class practica
    {
        public static void Main(string[] args)
        {
            string num1 = "";
            double num2 = 0;
            char operacion;

            while (true)
            {
                // Peticion de datos
                c.WriteLine("Introduzca el numero 1");
                num1 = c.ReadLine();

                if (num1 == "fin")
                {
                    c.WriteLine("Hasta otra...");
                    c.WriteLine();
                    c.WriteLine("Pulse cualquier tecla para salir del programa");
                    c.ReadKey();
                    return;
                }

                c.WriteLine("Introduzca la operacion");
                operacion = Convert.ToChar(c.ReadLine());

                if ((operacion != 'R') && (operacion != 'F') && (operacion != 'A'))
                {
                    c.WriteLine("Introduzca el numero 2");
                    num2 = Convert.ToDouble(((c.ReadLine())));
                }
                c.WriteLine();
                c.WriteLine("Resultado:");
                c.WriteLine();

                // calculo de operaciones

                double num1_calc = (Convert.ToDouble(num1));

                switch (operacion)
                {
                    case '+':
                        c.WriteLine(num1_calc + num2);
                        break;

                    case '-':
                        c.WriteLine(num1_calc - num2);
                        break;

                    case '*':
                        c.WriteLine(num1_calc * num2);
                        break;

                    case '/':
                        c.WriteLine(num1_calc / num2);
                        break;

                    case 'P':
                        int i = 0;
                        while (i < (int)num2 - 1)
                        {
                            num1_calc = num1_calc * num1_calc;
                            i++;
                        }
                        c.WriteLine(num1_calc);
                        break;

                    case 'R':
                        num1_calc = Math.Sqrt(num1_calc);
                        c.WriteLine(num1_calc);
                        break;

                    case 'A':
                        if (num1_calc < 0)
                        {
                            num1_calc = num1_calc * (-1);
                        }
                        c.WriteLine(num1_calc);
                        break;

                    case 'F':
                        int temp3 = (int)num1_calc;
                        for (int k = (int)num1_calc - 1; k > 0; k--)
                        {
                            temp3 = temp3 * k;
                        }
                        c.WriteLine(temp3);
                        break;

                    default:
                        break;
                }
                c.WriteLine();
            }
        }
    }
}