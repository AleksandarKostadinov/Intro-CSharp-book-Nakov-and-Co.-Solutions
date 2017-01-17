using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._08.GreatestOfFiveNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());

            a = a - ((a - b) & ((a - b) >> 31));
            a = a - ((a - c) & ((a - c) >> 31));
            a = a - ((a - d) & ((a - d) >> 31));
            a = a - ((a - f) & ((a - f) >> 31));
            Console.WriteLine(a);
        }
    }
}
