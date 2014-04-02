using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace csharp_pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList traductor = new SortedList();
            traductor.Add("{", "begin");
            traductor.Add("}", "begin");
            traductor.Add("WriteLine", "WriteLn");
            traductor.Add("ReadLine", "ReadLn");
            traductor.Add("void", "procedure");
            traductor.Add("Console", "");

            //StreamReader fichero_origen;
            //fichero_origen = File.OpenText("prueba.cs");
            List<string> lista = File.ReadAllLines("prueba.cs").ToList();
            //fichero_origen.Close();
            string itemaux = "";
            foreach (string item in lista)
            {
                itemaux = item;
                for (int i = 0; i < traductor.Count; i++)
                {
                    if (item.Contains(traductor.GetKey(i).ToString()))
                        itemaux = item.Replace(traductor.GetKey(i).ToString(), traductor.GetByIndex(i).ToString());
                }
                Console.WriteLine(itemaux);
            }
        }
    }
}


