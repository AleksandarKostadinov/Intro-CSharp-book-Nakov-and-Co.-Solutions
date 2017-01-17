using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._13.SetBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            n = n & (~(1 << p));
            n = n | (v << p);

            Console.WriteLine(n);
        }
    }
}
