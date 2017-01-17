using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._09.SumOfNNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nums to enterr N = ");
            int numsToEntered= int.Parse(Console.ReadLine());
            int sum = 0;
            int numsEntered = 0;
            Console.WriteLine("Enter N int nums.");
            while (numsEntered < numsToEntered)
            {
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    sum += a;
                    numsEntered++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter valid int num.");
                    continue;

                }
            }
            Console.WriteLine(sum);
        }
    }
}
