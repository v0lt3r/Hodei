using System;
using c = System.Console;

namespace statisticmenu
{
	class statisticmenu
	{
		struct point
		{
			public float data;
		}

		static void Main(string[] args)
		{
			const int SIZE = 1000;
			point[] puntos = new point[SIZE];
			int dato = 0;
			int opcion = 1;
			while (opcion<5)
			{
				//console.clear()
				c.WriteLine("choose an option: ");
				c.WriteLine("1. add new data");
				c.WriteLine("2. See all data entered");
				c.WriteLine("3. Find an item, to see whether it has been entered or not");
				c.WriteLine("4. View a summary of statistics: amount of data, sum, average, maximum, minimum");
				c.WriteLine("5. Exit");
				opcion = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine();
				switch (opcion)
				{
					case 1:
                    c.Write("insert data");
					puntos[dato].data = Convert.ToInt32(Console.ReadLine());				
					c.WriteLine();
					dato++;
					break;
					case 2:
					for (int i = 0; i<dato; i++)
					{
						Console.WriteLine(puntos[i].data);
					}

					break;
					case 3:
					bool comprobacion;
					
					for (int i=0; i<dato; i++)
					{
						if (... in ...)
						if (comprobacion)
							Console.WriteLine("se ha encontrado en la base de datos");	
					}
					
					
                    double sumax = 0;
					double sumay = 0;
					for (int i = 0; i < dato; i++)
					{
						sumax = sumax + puntos[i].data;
						sumay = sumay + puntos[i].data;
					}

					c.WriteLine("the average point for x is:{0};y:{1}", sumax / dato, sumay / dato);
					break;
					case 4:
					
					break;
                    default:

                        break;
                        
                }
            }
		}
	}
}
