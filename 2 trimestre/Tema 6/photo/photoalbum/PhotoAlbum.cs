using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoalbum
{
    class PhotoAlbum
    {
        protected int numberOfPages;
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
        public PhotoAlbum()
        {
            numberOfPages = 16;
        }
        public PhotoAlbum(int numP)
        {
            numberOfPages = numP;
        }
    }
}
