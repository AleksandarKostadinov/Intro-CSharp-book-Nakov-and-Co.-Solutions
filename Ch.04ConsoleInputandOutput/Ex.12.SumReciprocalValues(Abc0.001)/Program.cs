using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._12.SumReciprocalValues_Abc0._001_
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldSum = 1;
            double currentSum = 0;
            double devidor = 2;
            do
            {
                currentSum = oldSum + (1 / devidor) * Math.Pow(-1,devidor);
                if (Math.Abs(currentSum - oldSum) < 0.001)
                {
                    break;
                }
                oldSum = currentSum;
                devidor++;
            }
            while (true);
            Console.WriteLine(currentSum);
        }
    }
}
