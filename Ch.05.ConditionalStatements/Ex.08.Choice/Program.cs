using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._08.Choice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose int, double or string");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "int":
                    var intChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine(intChoice + 1); break;
                case "double":
                    var doubleChoice = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleChoice + 1); break;
                case "string":
                    Console.WriteLine(Console.ReadLine() + "*"); ; break;
                default:
                    Console.WriteLine("Invalid choice.");break;
            }
        }
    }
}
