using System;
using c = System.Console;

namespace arraystruct
{
	class arraystruct
	{
		struct point
		{
			public int x;
			public int y;
		}

		static void Main(string[] args)
		{
			point[] puntos = new point[100];
			int dato = 0;
			int opcion = 1;
			while (option<4)
			{
				c.WriteLine("choose an option: ");
				c.WriteLine("1. Add data for one point");
				c.WriteLine("2. Display all the entered points");
				c.WriteLine("3. Calculate (and display) the average values for x and y");
				c.WriteLine("4. Exit the program");
				opcion = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine();
				switch (opcion)
				{
					case 1:
                    c.Write("insert x for the new point > ");
					puntos[dato].x = Convert.ToInt32(Console.ReadLine());				
					c.WriteLine();
					c.Write("insert y for the new point > ");
					puntos[dato].y = Convert.ToInt32(Console.ReadLine());	
					dato++;
					break;
					case 2:
					for (int i = 0; i<dato; i++)
					{
						Console.WriteLine(puntos[i].x + " " + puntos[i].y);
					}

					break;
					case 3:
                    double sumax = 0;
					double sumay = 0;
					for (int i = 0; i < dato; i++)
					{
						sumax = sumax + puntos[i].x;
						sumay = sumay + puntos[i].y;
					}

					c.WriteLine("the average point for x is:{0};y:{1}", sumax / dato, sumay / dato);
					break;
                    default:

                        break;
                        
                }
            }
		}
	}
}
