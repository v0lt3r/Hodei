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

        public File(string newName, string newCode, double newSize)
        {
            name = newName;
            code = newCode;
            size = newSize;
            category = "generic";
        }

        public virtual void ShowData()
        {
            Console.WriteLine("{0} {1} {2} {3} ", name, code, category, size);
        }
    }
}
