using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._07.Entering5Nums_TryCatch_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEntered = 0;
            int sum = 0;
            Console.WriteLine("Enter 5 int nums.");
            while (numEntered < 5)
            {
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    sum += a;
                    numEntered++;
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
