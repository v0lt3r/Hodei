using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFi
{
    class CompProgram: File
    {
        public CompProgram()
        {
            category = "CompProgram";
        }

        public override void ShowData()
        {
            Console.WriteLine("{0} {1} {2} {3} ", name, code, category, size);
            Console.WriteLine();

        }
    }
}
