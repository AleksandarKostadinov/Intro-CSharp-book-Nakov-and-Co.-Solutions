using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._01.ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            int greaterNum = int.Parse(Console.ReadLine());
            int lesserNum = int.Parse(Console.ReadLine());

            if (lesserNum > greaterNum)
            {
                int temp = greaterNum;
                greaterNum = lesserNum;
                lesserNum = temp;

            }
            if (lesserNum != greaterNum)
            {
                Console.WriteLine("Greater : {0}\r\nLesser : {1}",greaterNum, lesserNum);
            }
            else
            {
                Console.WriteLine("Equal.");
            }
        }
    }
}
