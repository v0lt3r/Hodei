using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFi
{
    class CompProgram: File
    {
        public CompProgram(string newName, string newCode, double newSize)
        {
            name = newName;
            code = newCode;
            category = "CompProgram";
            size = newSize;
        }

        public override void ShowData()
        {
            Console.WriteLine("{0} {1} {2} {3} ", name, code, category, size);
        }
    }
}
