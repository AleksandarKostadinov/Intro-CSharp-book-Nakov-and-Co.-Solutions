using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_operator
{
    class IsOperator
    {
        static void Main(string[] args)
        {
            var number = 5;
            bool isIt = number is int; 
            System.Console.WriteLine(isIt);
        }
    }
}
