using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._04.ThreeColmnsOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((7));
            int a = 56;
            var b = 8.903;
            var c = 8887.56789;
            Console.WriteLine("|{0,-10:X}||{1,-10:F2}||{2,-10:F2}|",a , b, c);
            Console.WriteLine(new string('.',40));
        }
    }
}
