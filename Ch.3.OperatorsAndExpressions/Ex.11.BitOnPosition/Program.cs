using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._11.BitOnPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            if ((number & 1<< position) > 0)
            {

                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
