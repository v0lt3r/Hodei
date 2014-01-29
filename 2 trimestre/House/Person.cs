using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House1
{
    public class Person
    {
        string name;
        House s1 = new House(area);


        public Person()
        {
            name = "juan";
        }

        public Person(string newName) 
        {
            name = newName;
        }

        public void SetHouse()
        {
            SmallApartment s1 = new SmallApartment();
        }

        public void SetHouse(int area)
        {
            House s1 = new House(area);
        }

    }
}
