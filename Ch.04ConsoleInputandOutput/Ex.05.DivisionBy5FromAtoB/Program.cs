using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._05.DivisionBy5FromAtoB
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int zeroDivisions = 0;
            for (int i = Math.Min(a,b); i <= Math.Max(a, b) ; i++)
            {
                if (i % 5 == 0)
                {
                    zeroDivisions++;
                }
            }
            Console.WriteLine(zeroDivisions);
        }
    }
}
