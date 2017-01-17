using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._03.CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is for entering and printing company infirmation.");
            Console.WriteLine("Enter company name");
            var companyName = Console.ReadLine();
            Console.WriteLine("Enter company address.");
            var address = Console.ReadLine();
            Console.WriteLine("Enter company phone number.");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter company fax number.");
            var faxNumber = Console.ReadLine();
            Console.WriteLine("Enter company manager name.");
            var managerName = Console.ReadLine();
            Console.WriteLine("Enter company manager surname.");
            var managerSurname = Console.ReadLine();
            Console.WriteLine("Enter company manager phone number.");
            var managerPhoneNumber = Console.ReadLine();

            Console.WriteLine("The company's name is {0}.",companyName);
            Console.WriteLine("The company's adress is {0}.", address);
            Console.WriteLine("The company's phone number is {0}.", phoneNumber);
            Console.WriteLine("The company's fax number is {0}.", faxNumber);
            Console.WriteLine("The company's manager full name is {0} {1}.", managerName, managerSurname);
            Console.WriteLine("The company's manager phone number is {0}.", managerPhoneNumber);




        }
    }
}
