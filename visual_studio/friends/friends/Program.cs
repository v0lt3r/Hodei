using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friends
{
    public class friends
    {
        struct datos
        {
            public string name;
            public string mail;
            public string address;
            public int year;
        }
        public static void Main(string[] args)
        {
            datos [] friends = new datos [275];

            char opcion = '0';
            int index = 0;
            byte posicion_dato;
            string tempname = "";
            string tempmail = "";
            string tempaddress = "";
            int tempyear = 0;
            bool comprobacion = false;
            bool encontrado = false;

            do
            {
                switch (opcion)
                {
                    case '1': // añade datos al final
                        while (comprobacion = false)
                        {
                            Console.WriteLine("Write the name to add:");
                            tempname = Console.ReadLine();
                            if (tempname.Length < 40)
                            {
                                friends[index].name = tempname;
                                comprobacion = true;
                            }
                        }
                        comprobacion = false;

                        while (comprobacion = false)
                        {
                            Console.WriteLine("Write the mail of the person:");
                            tempmail = Console.ReadLine();
                            if (tempmail.Length < 30)
                            {
                                friends[index].mail = tempmail;
                                comprobacion = true;
                            }
                        }
                        comprobacion = false;

                        while (comprobacion = false)
                        {
                            Console.WriteLine("Write the address of the person:");
                            tempaddress = Console.ReadLine();
                            if (tempaddress.Length < 150)
                            {
                                friends[index].address = tempaddress;
                                comprobacion = true;
                            }
                        }
                        comprobacion = false;

                        while (comprobacion = false)
                        {
                            Console.WriteLine("Write the year of the person:");
                            tempyear = Convert.ToInt16(Console.ReadLine());
                            if (tempyear > 1850 && tempyear < 2100)
                            {
                                friends[index].year = tempyear;
                                comprobacion = true;
                            }
                        }
                        comprobacion = false;
                        index++;
                        break;
                    case '2':
                        if (index == 0)
                        {
                            Console.Write("no hay datos que mostrar");
                        }
                        else
                        {
                            for (int i = 0; i < index; i++)
                            {                            
                                if (i > 0 && i%20 == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Pulse enter para ver los siguientes 20");
                                    Console.ReadLine();
                                }
                                if (friends[i].name.Length < 30)
                                    Console.WriteLine("{0}", friends[i].name);                           
                                else                               
                                    Console.WriteLine("{0}", friends[i].name.Substring(0, 30) + "...");                              
                            } 
                        }
                            Console.WriteLine();                          
                        break;
                    case '3':

                    while (comprobacion = false)
                        {
                            Console.WriteLine("Write the name to add:");
                            tempname = Console.ReadLine();
                            if (tempname.Length < 40)
                            {
                                comprobacion = true;
                            }              
                        }

                    for (int i = 0; i < index; i++)
                    {
                        if (tempname.ToLower() == friends[i].name.ToLower())
                        {
                            Console.WriteLine("{0}", friends[i].name);
                            Console.WriteLine("{0}", friends[i].mail);
                            Console.WriteLine("{0}", friends[i].address);
                            Console.WriteLine("{0}", friends[i].year);
                            i = index + 1;
                            encontrado = true;
                        }
                    }
                        if (encontrado == false)
                        {
                            Console.WriteLine("no se ha encontrado el nombre");
                        }

                        encontrado = false;
                        comprobacion = false;

                        break;
                    case '4':
                        int anyo;
                        Console.WriteLine("Escriba el primer año a comprobar");
                        int.TryParse(Console.ReadLine(), out anyo);
                        int anyo2;
                        Console.WriteLine("Escriba el segundo año a comprobar");
                        int.TryParse(Console.ReadLine(), out anyo2);

                        for (int i = 0; i < index; i++)
                        {

                        }

                        break;
                    case '5':

                        break;
                    case '6':

                        break;
                    case '7':

                        break;
                }

            } while (opcion != 'x');
        }
    }
}
