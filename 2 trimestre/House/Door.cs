using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House1
{
    class Door
    {
        string color;

        public Door()
        {
            SetColor("brown");
        }
        public Door(string newColor)
        {
            SetColor(newColor);
        }

        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0}", color);
        }

        protected string GetColor()
        {
            return color;
        }

        public void SetColor(string newColor)
        {
            color = newColor;
        }
    }
}
