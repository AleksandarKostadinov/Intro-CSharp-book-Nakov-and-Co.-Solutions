using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._14.CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dividirs = 0;

            for (int i = 2; i < 100; i++)
            {
                if (n % i == 0)
                {
                    dividirs++;
                }
            }
            if (dividirs == 1)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
