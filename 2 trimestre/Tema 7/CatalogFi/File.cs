using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFi
{
    class File
    {
        protected string name;
        protected string code;
        protected string category;
        protected double size;

        public File()
        {
            category = "generic";
        }


        public void SetItem()
        {
            Console.WriteLine("Write the name ");
            name = Console.ReadLine();

            Console.WriteLine("Write the code ");
            code = Console.ReadLine();

            Console.WriteLine("Write the size ");
            if (!double.TryParse(Console.ReadLine(), out size))
                size = -1;
        }

        public virtual void ShowData()
        {
            Console.WriteLine("{0} {1} {2} {3} ", name, code, category, size);
        }
    }
}
