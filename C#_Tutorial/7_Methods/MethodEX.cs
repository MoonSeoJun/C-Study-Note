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
            SayHi("Moon", 18);
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
