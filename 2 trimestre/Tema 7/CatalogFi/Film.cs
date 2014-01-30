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

        public Film()
        {
            category = "Film";
        }

        public new void SetItem()
        {
            base.SetItem();
            Console.WriteLine("Write the director ");
            director = Console.ReadLine();

            Console.WriteLine("Write the main actor ");
            main_actor = Console.ReadLine();

            Console.WriteLine("Write the main actress ");
            main_actress = Console.ReadLine();
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
