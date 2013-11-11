using System;
using c = System.Console;
//int numero = readint();
//c.Write("hola");
//c.WriteLine("linea");

namespace cualencual
{
	class cualencual
	{
		//ATAJOS		
		static string read()
		{
			return Console.ReadLine();
		}

		static int readint()
		{
			return Convert.ToInt32(read());
		}

		//PROGRAMA		
		static void Main(string[] args)
		{
			int[] data = new int[5];
			int[] data2 = new int[5];

			for (int i = 0;i<5;i++)
			{
				c.Write("Enter number {0}: ", i+1);
				data[i] = Convert.ToInt32(c.ReadLine());
			}

			for (int i = 0;i<5;i++)
			{
				c.Write("Enter number {0}: ", i+1);
				data2[i] = Convert.ToInt32(c.ReadLine());
			}

			for (int i = 0;i<5;i++)
			{
				c.Write("{0} \t", data[i]);
			}

			c.Write("\n");

			for (int i = 0;i<5;i++)
			{
				c.Write("{0} \t", data2[i]);
			}

			c.Write("\n");

			for (int i = 0;i<5;i++)
			{
				for (int k = 0;k<5;k++)
				{
					if (data[i] == data2[k])
					{
						c.Write("{0} \t", data[i]);
					}
				}
			}  
		}
	}
}
