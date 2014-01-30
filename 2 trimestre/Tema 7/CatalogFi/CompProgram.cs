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

        public new void SetItem(string newName, string newCode, double newSize)
        {
            base.SetItem();
        }

        public override void ShowData()
        {
            Console.WriteLine("{0} {1} {2} {3} ", name, code, category, size);
        }
    }
}
