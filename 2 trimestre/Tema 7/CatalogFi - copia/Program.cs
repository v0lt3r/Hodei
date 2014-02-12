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
            File[] catalog = new File[10];
            File[] catalog1 = new Music[10];
            File[] catalog2 = new Film[10];
            File[] catalog3 = new CompProgram[10];
            int index = 0;
            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            int option = -1;

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

                        catalog1[index1] = new Music();
                        catalog1[index1].SetItem();
                        index1++;
                        break;

                    case 2:
                        catalog2[index2] = new Film();
                        catalog2[index2].SetItem();
                        index2++;
                        break;

                    case 3:
                        catalog3[index3] = new CompProgram();
                        catalog3[index3].SetItem();
                        index3++;
                        break;

                    case 4: // See all stored data
                        for (int i = 0; i < index; i++)
                        {
                            catalog[i].ShowData();
                        }
                        
                        for (int i = 0; i < index1; i++)
                        {
                            catalog1[i].ShowData();
                        }
                        
                        for (int i = 0; i < index2; i++)
                        {
                            catalog2[i].ShowData();
                        }

                        for (int i = 0; i < index3; i++)
                        {
                            catalog3[i].ShowData();
                            Console.WriteLine();
                        }
                        break;
                        
                }
            } while (option != 0);
        }
    }
}
