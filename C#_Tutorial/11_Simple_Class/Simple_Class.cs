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

            subBook.title = "BBC";
            subBook.author = "me";
            subBook.pages = 14;

            Console.WriteLine(subBook.title);
            Console.WriteLine(subBook.author);
            Console.WriteLine(subBook.pages);
        }
    }
}
