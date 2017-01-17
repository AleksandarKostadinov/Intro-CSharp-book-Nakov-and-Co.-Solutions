using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ex._05.SumOfFirstNFibunacci
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {

                int n = int.Parse(Console.ReadLine());
                Console.Write("First {0} fibunacci numbers are :", n);
                if (n == 1)
                {
                    Console.Write(0);
                }
                else
                {

                    Console.Write("0, 1");
                }
                BigInteger lastNum = 0;
                BigInteger currentNum = 1;
                BigInteger sum = 1;
                for (int i = 3; i <= n; i++)
                {
                    BigInteger nextNum = lastNum + currentNum;
                    Console.Write(", {0}", nextNum);
                    lastNum = currentNum;
                    currentNum = nextNum;
                    sum += nextNum;
                }
                Console.WriteLine();
                if (n == 1)
                {
                    sum = 0;
                }
                Console.WriteLine("There sum is : {0}", sum);
            }
        }
    }
}
