using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._04.Sort3Ints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[3];

            for (int i = 0; i < 3; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(myArray);
            Array.Reverse(myArray);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
