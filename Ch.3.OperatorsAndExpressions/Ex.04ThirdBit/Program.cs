using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._04ThirdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is the third bir of a number

            int num = int.Parse(Console.ReadLine());

            if ((1 & num >>3)==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
