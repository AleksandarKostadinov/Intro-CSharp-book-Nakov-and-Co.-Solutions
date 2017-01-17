using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._16.RandomToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program randomizes the nimber from 1 to N. \r\nEnter n ");
            int n = int.Parse(Console.ReadLine());
            var random = new Random();
            var numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }
            while (n > 1)
            {
                n--;
                int k = random.Next(n);
                int temp = numbers[k];
                numbers[k] = numbers[n];
                numbers[n] = temp;
                
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
