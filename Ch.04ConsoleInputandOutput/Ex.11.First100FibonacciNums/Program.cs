using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._11.First100FibonacciNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0, 1");
            ulong lastNum = 0;
            ulong currentNum = 1;
            
            for (int i = 0; i < 98; i++)
            {
                ulong nextNum = lastNum + currentNum;
                Console.Write(", {0}", nextNum);
                lastNum = currentNum;
                currentNum = nextNum;
               
            }
        }
    }
}
