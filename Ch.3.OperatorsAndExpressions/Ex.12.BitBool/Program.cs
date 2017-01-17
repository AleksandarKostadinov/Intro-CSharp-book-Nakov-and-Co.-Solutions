using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._12.BitBool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine((v & 1<< p) > 0);
        }
    }
}
