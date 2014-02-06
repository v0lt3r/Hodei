using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House1
{
    public class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House(400);
            h1.ShowData();
            h1.SetDoor("red");
            h1.GetDoor();

            Person juan = new Person("Juan");
            juan.SetHouse();
            
        }
    }
}
