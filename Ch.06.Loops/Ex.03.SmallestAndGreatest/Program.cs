using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._03.SmallestAndGreatest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do wish to enter.\r\n");
            int n = int.Parse(Console.ReadLine());
            int smallest = Int32.MaxValue;
            int greatest = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > greatest)
                {
                    greatest = currentNum;
                }
                if (currentNum < smallest)
                {
                    smallest = currentNum;
                }
            }
            Console.WriteLine("Greatest number is : " + greatest);
            Console.WriteLine("Smallest number is : " + smallest);

        }
    }
}
