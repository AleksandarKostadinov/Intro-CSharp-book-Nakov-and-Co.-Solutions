using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentNum = 2;
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0}, ",currentNum);
                if (currentNum<0)
                {
                currentNum -= 1;

                }else
                {
                    currentNum++;
                }
                currentNum *= -1;
            }
        }
    }
}
