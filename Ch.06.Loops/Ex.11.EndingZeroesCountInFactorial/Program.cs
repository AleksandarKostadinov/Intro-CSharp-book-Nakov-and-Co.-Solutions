using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._11.EndingZeroesCountInFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = int.Parse(Console.ReadLine());
            int zeroesCount = 0;
            for (int i = 1; i <= parameter; i++)
            {
                if (i % 5 == 0)
                {
                    zeroesCount++;
                }
            }
            Console.WriteLine(zeroesCount);
        }
    }
}
