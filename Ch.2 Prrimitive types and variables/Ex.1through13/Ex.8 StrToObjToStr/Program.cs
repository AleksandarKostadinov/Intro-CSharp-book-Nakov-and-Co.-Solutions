using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._8_StrToObjToStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World!";
            object c = a + " " + b;
            string d = (string)c;
            Console.WriteLine(d);
        }
    }
}
