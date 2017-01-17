using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._07.GreatestOf5Ints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(myArray);
            Console.WriteLine(myArray[4]);
        }
    }
}
