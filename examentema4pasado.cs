using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examentema4pasado
{
    public class Program
    {
        struct ram
        {
            public string unit;
            public int size;

        }
        struct pc
        {
            public string brand;
            public string model;          
            public int year;
            public ram ram;
            public string comments;    
        }
        static void Main(string[] args)
        {
            pc[] ordenadores = new pc[600];

            char opcion = '0';
            bool comprobacion = false;
            int index = 0;
            byte posicion_dato;
            string tempbrand = "";
            string tempmodel = "";
            int tempyear = 0;
            int tempsize = 0;
            string tempunit = "";
            string tempcomments = "";
            int dato = 0;

            do
            {
               Console.WriteLine(" 1 - Add a new computer data"                           );
               Console.WriteLine(" 2 - Show all brands and models of computers stored."   );
               Console.WriteLine(" 3 - Search for computers that contain a certain text"  );
               Console.WriteLine(" 4 - Update a record"                                   );
               Console.WriteLine(" 5 - Delete some data"                                  );
               Console.WriteLine(" 6 - Insert data in a position chosen"                  );
               Console.WriteLine(" 7 - Sort the data alphabetically by brand+model."      );
               Console.WriteLine(" 8 - Remove extra spaces "                              );
               Console.WriteLine(" Q - Quit");
               string temp2 = Console.ReadLine();
               opcion = temp2[0];

                switch (opcion)
                {
                    case '1': // añade datos al final
                        while (comprobacion == false) // tambien se puede con do-while
                        {
                            Console.WriteLine("Write a brand name to add:");
                            tempbrand = Console.ReadLine();
                            if (tempbrand != "" && tempbrand.Length < 50)
                            {
                                ordenadores[index].brand = tempbrand;
                                comprobacion = true;
                            }
                        }
                        comprobacion = false;

                        Console.WriteLine("Write the model of the pc:");
                        tempmodel = Console.ReadLine();
                        ordenadores[index].model = tempmodel;
                         
                        Console.WriteLine("Write the manufacture year:");
                        int.TryParse(Console.ReadLine(), out tempyear);
                        ordenadores[index].year = tempyear;

                        Console.WriteLine("Write the unit measure for ram:");
                        tempunit = Console.ReadLine();
                        ordenadores[index].ram.unit = tempunit;

                        Console.WriteLine("Write the size of the ram:");
                        int.TryParse(Console.ReadLine(), out tempsize);
                        ordenadores[index].ram.size = tempsize;

                        Console.WriteLine("Write some comments for this pc:");
                        tempmodel = Console.ReadLine();
                        ordenadores[index].comments = tempcomments;

                        comprobacion = false;
                        index++;
                        break;
                    case '2':  

                        if (index == 0)
                        {
                            Console.Write("there is no data to show");
                        }
                        else
                        {
                            for (int i = 0; i < index; i++)
                            {
                                if (i > 0 && i % 24 == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Press enter to continue");
                                    Console.ReadLine();
                                    Console.WriteLine(ordenadores[i].brand + "-" + ordenadores[i].model);
                                }                          
                            } 
                        }
                        Console.WriteLine();   
                        break;

                    case '3': //falta el case insensitive

                        string busqueda = "";
                        Console.WriteLine("Write the text to search");
                        busqueda = Console.ReadLine();

                        for (int i = 0; i < index; i++)
                        {
                            if (ordenadores[i].brand.Contains(busqueda) || ordenadores[i].model.Contains(busqueda) || ordenadores[i].comments.Contains (busqueda))
                            {
                                Console.WriteLine(ordenadores[i].brand);
                                Console.WriteLine(ordenadores[i].model);
                                Console.WriteLine(ordenadores[i].year);
                                Console.WriteLine(ordenadores[i].comments);                    
                                Console.WriteLine(ordenadores[i].ram.unit);
                                Console.WriteLine(ordenadores[i].ram.size);
                                Console.WriteLine("_________________________");
                            }
                        }
                        break;
                    case '4':
           
                            Console.WriteLine("introduzca el numero de dato a modificar");                                                    
                            if(int.TryParse(Console.ReadLine(), out dato))
                            {
                                while (comprobacion == false) // tambien se puede con do-while
                                {
                                    Console.WriteLine("Write a brand name to add:");
                                    tempbrand = Console.ReadLine();
                                    if (tempbrand != "" && tempbrand.Length < 50)
                                    {
                                        ordenadores[dato].brand = tempbrand;
                                        comprobacion = true;
                                    }
                                }
                                comprobacion = false;

                                Console.WriteLine("Write the model of the pc:");
                                tempmodel = Console.ReadLine();
                                ordenadores[dato].model = tempmodel;

                                Console.WriteLine("Write the manufacture year:");
                                int.TryParse(Console.ReadLine(), out tempyear);
                                ordenadores[dato].year = tempyear;

                                Console.WriteLine("Write the unit measure for ram:");
                                tempunit = Console.ReadLine();
                                ordenadores[dato].ram.unit = tempunit;

                                Console.WriteLine("Write the size of the ram:");
                                int.TryParse(Console.ReadLine(), out tempsize);
                                ordenadores[dato].ram.size = tempsize;

                                Console.WriteLine("Write some comments for this pc:");
                                tempmodel = Console.ReadLine();
                                ordenadores[dato].comments = tempcomments;
			                }     
                            else
                            {
                                Console.WriteLine("se ha introducido un numero incorrecto");
                        
                            }
                    break;

                    case '5': //borrar dato

                        Console.WriteLine("introduzca el numero de dato a modificar");
                        if(int.TryParse(Console.ReadLine(), out dato) && dato<=index)
                        {
                            for (int i = dato-1; i < index; i++)
                            {   //se puede optimizar en una linea
                                ordenadores[i].brand    = ordenadores[i+1].brand;                      
                                ordenadores[i].model    = ordenadores[i+1].model;
                                ordenadores[i].year     = ordenadores[i+1].year;
                                ordenadores[i].ram.unit = ordenadores[i+1].ram.unit;
                                ordenadores[i].ram.size = ordenadores[i+1].ram.size;
                                ordenadores[i].comments = ordenadores[i+1].comments;
                            }
                            index--;
                        }

                        else
                        {
                            Console.WriteLine("se ha introducido un numero incorrecto");
                        }
                        
                    break;
                    case '6': // INSERTAR DATOS

                         Console.WriteLine("introduzca el numero de dato a modificar");
                        if(int.TryParse(Console.ReadLine(), out dato) && dato<=index)
                        {
                            for (int i = index-1; i >=dato-1 ; i--)
                            {   //se puede optimizar en una linea
                                ordenadores[i+1].brand    = ordenadores[i].brand   ;                      
                                ordenadores[i+1].model    = ordenadores[i].model   ;
                                ordenadores[i+1].year     = ordenadores[i].year    ;
                                ordenadores[i+1].ram.unit = ordenadores[i].ram.unit;
                                ordenadores[i+1].ram.size = ordenadores[i].ram.size;
                                ordenadores[i+1].comments = ordenadores[i].comments;
                            }
                            index++;

                            while (comprobacion == false) // tambien se puede con do-while
                            {
                                Console.WriteLine("Write a brand name to add:");
                                tempbrand = Console.ReadLine();
                                if (tempbrand != "" && tempbrand.Length < 50)
                                {
                                    ordenadores[index].brand = tempbrand;
                                    comprobacion = true;
                                }
                            }
                            comprobacion = false;

                            Console.WriteLine("Write the model of the pc:");
                            tempmodel = Console.ReadLine();
                            ordenadores[index].model = tempmodel;

                            Console.WriteLine("Write the manufacture year:");
                            int.TryParse(Console.ReadLine(), out tempyear);
                            ordenadores[index].year = tempyear;

                            Console.WriteLine("Write the unit measure for ram:");
                            tempunit = Console.ReadLine();
                            ordenadores[index].ram.unit = tempunit;

                            Console.WriteLine("Write the size of the ram:");
                            int.TryParse(Console.ReadLine(), out tempsize);
                            ordenadores[index].ram.size = tempsize;

                            Console.WriteLine("Write some comments for this pc:");
                            tempmodel = Console.ReadLine();
                            ordenadores[index].comments = tempcomments;

                            comprobacion = false;
                        }

                        else
                        {
                            Console.WriteLine("se ha introducido un numero incorrecto");
                        }

                        break;

                    case '7':
                        string tipo;
                        Console.WriteLine("introduzca marca si quiere ordenar por marca, o modelo si quiere ordenar por modelo ");
                        tipo = Console.ReadLine();

                        if (tipo == "marca")
                        {
                            pc temp;
                            for (int i = 1; i < ordenadores.Length; i++)
                            {
                                for (int j = ordenadores.Length - 1; j >= i; j--)
                                {
                                    if (ordenadores[j - 1].brand.CompareTo(ordenadores[j].brand) > 0)
                                    {
                                        temp = ordenadores[j - 1];
                                        ordenadores[j - 1] = ordenadores[j];
                                        ordenadores[j] = temp;
                                    }
                                }
                            }
                        }

                        if (tipo == "modelo")
                        {
                            pc temp;
                            for (int i = 1; i < ordenadores.Length; i++)
                            {
                                for (int j = ordenadores.Length - 1; j >= i; j--)
                                {
                                    if (ordenadores[j - 1].model.CompareTo(ordenadores[j].model) > 0)
                                    {
                                        temp = ordenadores[j - 1];
                                        ordenadores[j - 1] = ordenadores[j];
                                        ordenadores[j] = temp;
                                    }
                                }
                            }
                        }
                        break;

                    case '8':
                        for (int i = 0; i < ordenadores.Length; i++)
                        {
                            while (ordenadores[i].brand[0] == ' ')
                            {
                                ordenadores[i].brand.Remove(0, 1);
                            }
                            while (ordenadores[i].brand[ordenadores[i].brand.Length - 1] == ' ')
                            {
                                ordenadores[i].brand.Remove(ordenadores[i].brand.Length - 1, 1);
                            }

                            while (ordenadores[i].model[0] == ' ')
                            {
                                ordenadores[i].model.Remove(0, 1);
                            }
                            while (ordenadores[i].model[ordenadores[i].model.Length - 1] == ' ')
                            {
                                ordenadores[i].model.Remove(ordenadores[i].model.Length - 1, 1);
                            }

                            while (ordenadores[i].comments[0] == ' ')
                            {
                                ordenadores[i].comments.Remove(0, 1);
                            }
                            while (ordenadores[i].comments[ordenadores[i].comments.Length - 1] == ' ')
                            {
                                ordenadores[i].comments.Remove(ordenadores[i].comments.Length - 1, 1);
                            }
                        }
                        break;    
                }
            } while (opcion != 'Q');
        }
    }  
}