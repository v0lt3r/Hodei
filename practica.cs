using System;
using c = System.Console;

public class practica
{
	public static void Main(string[] args)
	{
		double num1 = 0;
		double num2 = 0;
		char operacion = ' ';

		string salir = "";

		while (salir != "fin")
		{
			// Peticion de datos
			Console.WriteLine("Introduzca el numero 1");
			salir = Console.ReadLine();
			if (double.TryParse(salir, out num1))
			{
				Console.WriteLine("Introduzca la operacion");
				string temp = Console.ReadLine(); // Control de input
				operacion = temp[0];

				if ((operacion != 'R') && (operacion != 'F') && (operacion != 'A'))
				{
					Console.WriteLine("Introduzca el numero 2");
					if (!double.TryParse(Console.ReadLine(), out num2))
						operacion = ' ';
				}

				Console.WriteLine();
				Console.WriteLine("Resultado:");
			}
			else
				operacion = ' ';

			// calculo de operaciones
			switch (operacion)
			{
				case '+':
					c.WriteLine("{0} {1} {2} = {3}", num1, operacion, num2, (num1 + num2));
				break;

				case '-':
					c.WriteLine("{0} {1} {2} = {3}", num1, operacion, num2, (num1 - num2));
				break;

				case '*':
					c.WriteLine("{0} {1} {2} = {3}", num1, operacion, num2, (num1 * num2));
				break;

				case '/':
					c.WriteLine("{0} {1} {2} = {3}", num1, operacion, num2, (num1 / num2));
				break;

				case 'P':
					int i = 0;
				double result = num1;
				while(i < (int)num2-1)
				{
					result = result * num1;
					i++;
				}

				c.WriteLine("{0} {1} {2} = {3}", num1, operacion, (int)num2, result);
				break;

				case 'R':
					c.WriteLine("SQRT({0}) = {1}", num1, Math.Sqrt(num1));
				break;

				case 'A':
					double result2 = num1;
				if (num1 < 0)
				{
					result2 = num1 * (-1);
				}

				c.WriteLine("ABS({0}) = {1}", num1, result2);
				break;

				case 'F':
					int temp3 = (int) num1;
				for (int k = (int)num1-1; k > 0; k--)
				{
					temp3 = temp3 * k;
				}

				c.WriteLine("{0}! = {1}", (int)num1, temp3);
				break;

				default:
					if(salir != "fin")
						Console.WriteLine("Operacion no reconocida");
				break;
			}

			Console.WriteLine();
		}
		Console.WriteLine("pulse una tecla ... ");
		Console.ReadKey();
	}
}

