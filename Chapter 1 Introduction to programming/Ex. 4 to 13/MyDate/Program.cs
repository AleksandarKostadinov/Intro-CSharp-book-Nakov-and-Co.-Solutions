using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthDay= Console.ReadLine();
            string format = "dd/MM/yyyy HH:mm:ss";
            DateTime birthDayDT = DateTime.ParseExact(birthDay, format, null);
            DateTime currentDate = DateTime.Now;

            TimeSpan myDays = currentDate - birthDayDT;
            int days = int.Parse(myDays.ToString(format));
            Console.WriteLine(days);
        }
    }
}
