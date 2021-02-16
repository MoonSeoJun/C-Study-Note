using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Book subBook = new Book();

            subBook.TitleGS = "BBC";
            subBook.AuthorGS = "Moon";
            subBook.PagesGS = 14;

            Console.WriteLine(subBook.TitleGS);
            Console.WriteLine(subBook.AuthorGS);
            Console.WriteLine(subBook.PagesGS);
        }
    }
}
