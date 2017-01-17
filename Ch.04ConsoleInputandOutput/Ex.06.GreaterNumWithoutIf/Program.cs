using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._06.GreaterNumWithoutIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3000;
            int b = 2011;
            string c = Convert.ToString(a - ((a -b)& ((a - b)>>31)), 2);

            Console.WriteLine(c);
            Console.WriteLine(Convert.ToString(a,2));

        }
    }
}
