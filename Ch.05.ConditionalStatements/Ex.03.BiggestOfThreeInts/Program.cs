using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._03.BiggestOfThreeInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int biggest = a;

            if (b > a)
            {
                biggest = b;
                if (c > a)
                {
                    biggest = c;
                }

            }
            Console.WriteLine(biggest);
        }
    }
}
