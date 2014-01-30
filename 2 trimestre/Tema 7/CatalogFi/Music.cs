using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFi
{
    class Music: File
    {
        protected string singer;
        protected int length;

        public Music(string newName, string newCode, double newSize, string newSinger, int newLength)
        {
            name = newName;
            code = newCode;
            size = newSize;
            category = "music";
            singer = newSinger;
            length = newLength;
        }

        public override void ShowData()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} ", name, code, category, size, singer, length);
        }

        public void Play()
        {

        }

        public void RetrieveInformation()
        {

        }
    }
}
