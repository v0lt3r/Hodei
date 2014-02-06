using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFi
{
    class Program
    {
        static void Main(string[] args)
        {
            File[] catalog = new File[100];
            int index = 0;
            int option = -1;

            string name;
            string code;
            double size;
            string director;
            string main_actor;
            string main_actress;
            string singer;
            int length;

            do
            {
                Console.WriteLine("1. Add Music");
                Console.WriteLine("2. Add Movie");
                Console.WriteLine("3. Add Computer program");
                Console.WriteLine("4. View Catalog");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                if (!int.TryParse(Console.ReadLine(), out option))
                    option = 6;

                switch (option)
                {
                    case 1: // Add any kind of data
                        Console.WriteLine("Write the name ");
                        name = Console.ReadLine();

                        Console.WriteLine("Write the code ");
                        code = Console.ReadLine();

                        Console.WriteLine("Write the size ");
                        if (!double.TryParse(Console.ReadLine(), out size))
                            size = -1;

                        Console.WriteLine("Write the singer ");
                        singer = Console.ReadLine();

                        Console.WriteLine("Write the length ");
                        if (!int.TryParse(Console.ReadLine(), out length))
                            size = -1;

                        catalog[index] = new Music(name, code, size, singer, length);
                        index++;
                        break;

                    case 2:
                        Console.WriteLine("Write the name ");
                        name = Console.ReadLine();

                        Console.WriteLine("Write the code ");
                        code = Console.ReadLine();

                        Console.WriteLine("Write the size ");
                        if (!double.TryParse(Console.ReadLine(), out size))
                            size = -1;

                        Console.WriteLine("Write the director ");
                        director = Console.ReadLine();

                        Console.WriteLine("Write the main actor ");
                        main_actor = Console.ReadLine();

                        Console.WriteLine("Write the main actress ");
                        main_actress = Console.ReadLine();

                        catalog[index] = new Film(name, code, size, director, main_actor, main_actress);
                        index++;
                        break;

                    case 3:
                        Console.WriteLine("Write the name ");
                        name = Console.ReadLine();

                        Console.WriteLine("Write the code ");
                        code = Console.ReadLine();

                        Console.WriteLine("Write the size ");
                        if (!double.TryParse(Console.ReadLine(), out size))
                            size = -1;

                        catalog[index] = new CompProgram(name, code, size);
                        index++;
                        break;

                    case 4: // See all stored data
                        for (int i = 0; i < index; i++)
                        {
                            catalog[i].ShowData();
                            Console.WriteLine();
                        }
                        break;
                        
                }
            } while (option != 0);
        }
    }
}
