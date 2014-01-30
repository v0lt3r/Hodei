using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFi
{
    class Film: File
    {
        protected string director;
        protected string main_actor;
        protected string main_actress;

        public Film(string newName, string newCode, double newSize, string newDirector, string newMain_actor, string newMain_actress)
        {
            name = newName;
            code = newCode;
            size = newSize;
            category = "film";
            director = newDirector;
            main_actor = newMain_actor;
            main_actress = newMain_actress;
        }

        public override void ShowData()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} ", name, code, category, size, director, main_actor, main_actress);
        }

        public void Play()
        {
    
        }

        public void RetrieveInformation()
        {

        }
    }

}
