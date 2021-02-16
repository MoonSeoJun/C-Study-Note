using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lesson
{
    class Book
    {
        private string title;
        private string author;
        private int pages;

        public string TitleGS
        {
            get { return title; }
            set { title = value; }
        }

        public string AuthorGS
        {
            get { return author; }
            set { author = value; }
        }

        public int PagesGS
        {
            get { return pages; }
            set { pages = value; }
        }
    }
}
