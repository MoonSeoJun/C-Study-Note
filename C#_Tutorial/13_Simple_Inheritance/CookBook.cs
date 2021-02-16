using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lesson
{
    class CookBook : Book
    {
        private string Genre;
        private string Content;

        public string GenreGS
        {
            get { return Genre; }
            set { Genre = value; }
        }

        public string ContentGS
        {
            get { return Content; }
            set { Content = value; }
        }
    }
}
