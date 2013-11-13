using System;
using c = System.Console;
//int numero = readint();
//c.Write("hola");
//c.WriteLine("linea");

namespace arraystruct
{
	class arraystruct
	{
		struct point
		{
			public double x;
			public double y;
		}

		static void Main(string[] args)
		{
			point[] puntos = new point[100];
			int dato = 0;
			while (true)
			{
				c.WriteLine("Choose an option: ");
				c.WriteLine("1. Add data for one point");
				c.WriteLine("2. Display all the entered points");
				c.WriteLine("3. Calculate (and display) the average values for x and y");
				c.WriteLine("4. Exit the program");
				int opcion = Convert.ToInt32(Console.ReadLine());

				switch (opcion)
				{
					case 1:
                        c.Write("insert x for the new point > ");
					puntos[dato].x = Convert.ToInt32(Console.ReadLine());

					c.WriteLine();
					c.Write("insert y for the new point > ");
					puntos[dato].y = Convert.ToInt32(Console.ReadLine());

					dato++;
					c.Clear();
					break;
					case 2:
                        for (int i = 0; i < dato; i++)
					{
						c.WriteLine("Point {0} = {1};{2}", i, puntos[i].x, puntos[i].y);
					}

					c.WriteLine("Press a key");
					c.ReadKey();
					c.Clear();
					break;
					case 3:
                        double sumax = 0;
					double sumay = 0;
					for (int i = 0; i < dato; i++)
					{
						sumax = sumax + puntos[i].x;
						sumay = sumay + puntos[i].y;
					}

					c.WriteLine("Average point is x:{0};y:{1}", sumax / dato, sumay / dato);
					c.WriteLine("Press a key");
					c.ReadKey();
					c.Clear();
					break;
					case 4:
                        return;

					default:
						c.Clear();
                        break;
                }
            }
        }
    }
}
