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
            int[,] number_2d = { { 0, 3 }, { 1, 2 }, { 1, 1 } };

            Console.WriteLine(number_2d[0, 0]);
            Console.WriteLine(number_2d[1, 1]);
            Console.WriteLine(number_2d[1, 1]);
        }
    }
}
