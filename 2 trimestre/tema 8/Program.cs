using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Program
    {
        const int numVehiculos = 10;
        static Vehiculo[] parking = new Vehiculo[numVehiculos+1];
        static int index;
        
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Añadir vehiculo");
                Console.WriteLine("2. Lista vehiculos");
                Console.WriteLine("3. Cambiar neumaticos");
                Console.WriteLine("4. Salida Vehiculo");
                Console.WriteLine("5. Salir del programa");
                Console.WriteLine();
                if (!int.TryParse(Console.ReadLine(), out opcion))
                    opcion = 6;

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        if (index == numVehiculos-1)
                        {
                            Console.WriteLine("parking completo!");
                            break;
                        }
                        introducirDatos(comprobacionNumeros("quieres añadir un coche (1) o una moto (2)?", 2));
                        break;

                    case 2:
                        Console.Clear();
                        listaVehiculos();
                        break;

                    case 3:
                        Console.Clear();
                        listaVehiculos();
                        Console.WriteLine("");
                        setRuedas(parking[comprobacionNumeros("De que vehiculo quieres cambiar los neumaticos?", index)]);
                        break;

                    case 4:
                        Console.Clear();
                        listaVehiculos();
                        Console.WriteLine("");
                        borraVehiculo(comprobacionNumeros("Que vehiculo quieres dar de baja?", index));
                        break;

                    case 5:
                        Console.WriteLine("Hasta luego !!!!!!!");
                        break;

                    default:
                        break;
                }

                if (opcion == 6)
                    Console.WriteLine("opcion no valida!");
                else
                    Console.WriteLine("... pulsa una tecla");
                Console.ReadLine();

            } while (opcion != 5);          
        }


        static void introducirDatos(int opt)
        {
            string marca;
            string modelo;
            string conductor;
            string matricula;

            if (opt == 1)
                parking[index] = new Coche();
            else if (opt == 2)
                parking[index] = new Moto();

            Console.WriteLine("introduzca la marca");
            marca = Console.ReadLine();
            Console.WriteLine("introduzca el modelo");
            modelo = Console.ReadLine();
            Console.WriteLine("introduzca el nombre del conductor");
            conductor = Console.ReadLine();
            Console.WriteLine("introduzca la matricula (sigue el formato 0000 XXX)");
            matricula = Console.ReadLine();
            
            if (opt == 1)
            {
                parking[index] = new Coche(marca, modelo, matricula, conductor);
            }
            else if (opt == 2)
            {
                parking[index] = new Moto(marca, modelo, matricula, conductor);
            }
            
            setRuedas(parking[index]);
            
            index++;
        }

        static void setRuedas(Vehiculo temp)
        {
            string marca;
            string modelo;
            int radio;

            Console.WriteLine("Introduzca la Marca de los neumaticos");
            marca = Console.ReadLine();

            Console.WriteLine("Introduzca el modelo de neumatico");
            modelo = Console.ReadLine();
            
            Console.WriteLine("Introduzca el radio");
            while (!int.TryParse(Console.ReadLine(), out radio))
            {
                Console.WriteLine("Error!!! (Escriba un radio valido)");
                Console.WriteLine("Introduzca el radio");
            }
            temp.cambiaNeumaticos(marca, modelo, radio);
        }


        static void listaVehiculos()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("Vehiculo " + (i + 1) + "\t" + parking[i].GetMarca() + "\t"
                    + parking[i].GetModelo() + "\t" + parking[i].GetMatricula() + "\t"
                    + parking[i].GetConductor());
                Console.WriteLine("\t" + parking[i].showRuedas());
            }
        }

        static int comprobacionNumeros(string mensaje, int max)
        {
            int opcion2;

            Console.WriteLine(mensaje);
            while (!int.TryParse(Console.ReadLine(), out opcion2) || (opcion2 < 1 && opcion2 > max))
            {
                Console.WriteLine("Error (escriba un numero entre 1 y " + max + ")");
                Console.WriteLine(mensaje);
            }
            return opcion2;
        }

        static void borraVehiculo(int baja)
        {
            for (int i = (baja - 1); i < index; i++)
            {
                parking[i] = parking[i + 1];
            }
            index--;
        }
    }

////////////////////////////////////////////////////////////////////////////////////////////

    class Rueda
    {
        protected int radio;
        protected string marca;
        protected string modelo;

        public Rueda()
        {

        }

        public Rueda(int newRadio, string newMarca, string newModelo)
        {
            radio = newRadio;
            marca = newMarca;
            modelo = newModelo;
        }

        // marca
        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string newMarca)
        {
            marca = newMarca;
        }

        // modelo
        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string newModelo)
        {
            modelo = newModelo;
        }

        // radio
        public int GetRadio()
        {
            return radio;
        }

        public void SetRadio(int newRadio)
        {
            radio = newRadio;
        }


    }	

////////////////////////////////////////////////////////////////////////////////////////////

    class Vehiculo
    {
        protected int numRuedas;
        protected string marca;
        protected string modelo;
        protected string matricula;
        protected string conductor;
        protected Rueda[] arrayrueda;
        
        public Vehiculo() 
        {
            numRuedas = 5;
            arrayrueda = new Rueda[numRuedas];
        }

        public Vehiculo(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            marca = newMarca;
            modelo = newModelo;
            conductor = newConductor;
            arrayrueda = new Rueda[numRuedas];
            // Comprobacion del input de la matricula
            if(!SetMatricula(newMatricula))
            {
                do
                {
                    Console.WriteLine("Error, vuelva a escribir la matricula del vehiculo!!!!");
                } while (!SetMatricula(Console.ReadLine()));
            }
        }

        // marca
        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string newMarca)
        {
            marca = newMarca;
        }

        // modelo
        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string newModelo)
        {
            modelo = newModelo;
        }

        // matricula
        public string GetMatricula()
        {
            return matricula;
        }

        public Boolean SetMatricula(string newMatricula)
        {
            if (
                newMatricula.Length == 8 &&
                Char.IsDigit(newMatricula[0]) &&
                Char.IsDigit(newMatricula[1]) &&
                Char.IsDigit(newMatricula[2]) &&
                Char.IsDigit(newMatricula[3]) &&
                newMatricula[4] == ' ' &&
                Char.IsLetter(newMatricula[5]) &&
                Char.IsLetter(newMatricula[6]) &&
                Char.IsLetter(newMatricula[7])
				)
            {
                matricula = newMatricula;
                return true;
            }
            else
            {
                matricula = "ERROR";
                Console.WriteLine("Revisa la matricula");
                return false;
            }
        }

        // conductor
        public string GetConductor()
        {
            return conductor;
        }

        public void SetConductor(string newConductor)
        {
            conductor = newConductor;
        }

        public void cambiaNeumaticos(string marca, string modelo, int radio)
        {
            for (int i = 0; i < numRuedas; i++)
			{
                arrayrueda[i] = new Rueda(radio, marca, modelo);	 
			}
        }

        public string showRuedas()
        {
            string temp = "";

            for (int i = 0; i < numRuedas; i++)
            {
                temp += "Rueda" + (i + 1) + ": " + arrayrueda[i].GetMarca() + " | ";
            }
            return temp;
        }
    }

////////////////////////////////////////////////////////////////////////////////////////////

    class Coche: Vehiculo
    {
        public Coche() 
        {
            numRuedas = 4;
            arrayrueda = new Rueda[numRuedas];
        }

        public Coche(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            marca = newMarca;
            modelo = newModelo;
            conductor = newConductor;
            arrayrueda = new Rueda[numRuedas];
            // Comprobacion del input de la matricula
            if (!SetMatricula(newMatricula))
            {
                do
                {
                    Console.WriteLine("Error, vuelva a escribir la matricula del vehiculo!!!!");
                } while (!SetMatricula(Console.ReadLine()));
            }
        }
    }

////////////////////////////////////////////////////////////////////////////////////////////

    class Moto: Vehiculo
    {
        public Moto() 
        {
            numRuedas = 2;
            arrayrueda = new Rueda[numRuedas];
        }

        public Moto(string newMarca, string newModelo, string newMatricula, string newConductor)
        {
            marca = newMarca;
            modelo = newModelo;
            conductor = newConductor;
            arrayrueda = new Rueda[numRuedas];
            // Comprobacion del input de la matricula
            if (!SetMatricula(newMatricula))
            {
                do
                {
                    Console.WriteLine("Error, vuelva a escribir la matricula del vehiculo!!!!");
                } while (!SetMatricula(Console.ReadLine()));
            }
        }  
    }

}



