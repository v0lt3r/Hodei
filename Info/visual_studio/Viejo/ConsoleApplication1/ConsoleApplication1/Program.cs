using System;
using c = System.Console;

namespace arraystruct
{
    class arraystruct
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
            double[,] puntos = new double[100, 2];
            int dato = 0;
            while (true)
            {
                c.WriteLine("choose an option: ");
                c.WriteLine("1. Add data for one point");
                c.WriteLine("2. Display all the entered points");
                c.WriteLine("3. Calculate (and display) the average values for x and y");
                c.WriteLine("4. Exit the program");
                int opcion = readint();

                switch (opcion)
                {
                    case 1:
                        c.Write("insert x for the new point > ");
                        puntos[dato, 0] = readint();
                        c.WriteLine();
                        c.Write("insert y for the new point > ");
                        puntos[dato, 1] = readint();
                        dato++;
                        break;
                    case 2:
                        c.Write(puntos);
                        c.WriteLine();
                        break;
                    case 3:
                        double sumax = 0;
                        double sumay = 0;
                        for (int i = 0; i < dato; i++)
                        {
                            sumax = sumax + puntos[i, 0];
                            sumay = sumay + puntos[i, 1];
                        }
                        c.WriteLine("the average point for x is:{0};y:{1}", sumax / dato, sumay / dato);
                        break;
                    case 4:
                        Environment.Exit();
                        break;

                    default:

                        break;

                }
            }
        }
    }
}
