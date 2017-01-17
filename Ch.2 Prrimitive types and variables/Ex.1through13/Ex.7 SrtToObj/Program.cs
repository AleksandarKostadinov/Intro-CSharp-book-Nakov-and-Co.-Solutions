using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7_SrtToObj
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World!";
            object c = a + " " + b;
            Console.WriteLine(c);
        }
    }
}
