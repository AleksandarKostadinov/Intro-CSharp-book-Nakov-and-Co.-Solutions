using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._06.N_DevidedByK_
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int result = k + 1;
            for (int i = k +2; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("N!/K! = " + result);
        }
    }
}
