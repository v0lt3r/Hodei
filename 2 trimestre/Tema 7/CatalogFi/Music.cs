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

        public Music()
        {
            category = "music";
        }

        public new void SetItem()
        {
            base.SetItem();
            
            Console.WriteLine("Write the singer ");
            singer = Console.ReadLine();

            Console.WriteLine("Write the length ");
            if (!int.TryParse(Console.ReadLine(), out length))
                size = -1;
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
