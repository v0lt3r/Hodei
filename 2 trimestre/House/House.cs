using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House1
{
    public class House
    {
        int area;
        Door puerta = new Door();


        public House()
        {
            SetArea(200);
        }

        public House(int areaValue)
        {
            SetArea(areaValue);
        }

        public void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2", area);
        }

        protected int GetArea()
        {
            return area;
        }

        protected void SetArea(int newValue)
        {
            area = newValue;
        }

        public void SetDoor(string newColor)
        {
            puerta.SetColor(newColor); 
        }

        public void GetDoor()
        {
            puerta.ShowData();
        }
    }
}
