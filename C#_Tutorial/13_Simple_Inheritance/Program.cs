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
            CookBook cookBook = new CookBook();

            cookBook.TitleGS = "WonwuDad";
            cookBook.AuthorGS = "Wonwu";
            cookBook.PagesGS = 15;
            cookBook.GenreGS = "Cook";
            cookBook.ContentGS = "bla bla bla";

            Console.WriteLine(cookBook.TitleGS);
            Console.WriteLine(cookBook.AuthorGS);
            Console.WriteLine(cookBook.PagesGS);
            Console.WriteLine(cookBook.GenreGS);
            Console.WriteLine(cookBook.ContentGS);
        }
    }
}
