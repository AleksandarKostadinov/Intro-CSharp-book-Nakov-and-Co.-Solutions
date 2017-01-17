using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._11._0to999InWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int hundreds = n / 100;
            int tenths = (n - hundreds * 100) / 10;
            int ones = n % 10;

            if (n <= 20)
            {
                switch (n)
                {
                    case 0: Console.WriteLine("Zero"); break;
                    case 1: Console.WriteLine("One");break;
                    case 2: Console.WriteLine("Two");break;
                    case 3: Console.WriteLine("Three");break;
                    case 4: Console.WriteLine("Four");break;
                    case 5: Console.WriteLine("Five");break;
                    case 6: Console.WriteLine("Six");break;
                    case 7: Console.WriteLine("Seven"); break;
                    case 8: Console.WriteLine("Eight"); break;
                    case 9: Console.WriteLine("Nine"); break;
                    case 10: Console.WriteLine("Ten"); break;
                    case 11: Console.WriteLine("Eleven"); break;
                    case 12: Console.WriteLine("Twelve"); break;
                    case 13: Console.WriteLine("Thirteen"); break;
                    case 14: Console.WriteLine("Fourteen"); break;
                    case 15: Console.WriteLine("Fifteen"); break;
                    case 16: Console.WriteLine("Sixteen"); break;
                    case 17: Console.WriteLine("Seventeen"); break;
                    case 18: Console.WriteLine("Eighteen"); break;
                    case 19: Console.WriteLine("Nineteen"); break;
                    case 20: Console.WriteLine("Twenty"); break;


                    default:
                        Console.WriteLine("The number is too low.");
                        break;
                }
            }
            else if (n >20 && n < 100)
            {
                switch (tenths)
                {
                    case 2: Console.Write("Twenty");  break;
                    case 3: Console.Write("Thirty"); break;
                    case 4: Console.Write("Fourty"); break;
                    case 5: Console.Write("Fifty"); break;
                    case 6: Console.Write("Sixty"); break;
                    case 7: Console.Write("Seventy"); break;
                    case 8: Console.Write("Eighty"); break;
                    case 9: Console.Write("Ninety"); break;
                    default:
                        break;
                }
                switch (ones)
                {
                    case 0: Console.WriteLine(""); break;
                    case 1: Console.WriteLine("-one"); break;
                    case 2: Console.WriteLine("-two"); break;
                    case 3: Console.WriteLine("-three"); break;
                    case 4: Console.WriteLine("-four"); break;
                    case 5: Console.WriteLine("-five"); break;
                    case 6: Console.WriteLine("-six"); break;
                    case 7: Console.WriteLine("-seven"); break;
                    case 8: Console.WriteLine("-eight"); break;
                    case 9: Console.WriteLine("-nine"); break;
                    default:
                        break;
                }
            }
            else if (hundreds > 0 && n < 1000)
            {
                switch (hundreds)
                {
                    case 1: Console.Write("One"); break;
                    case 2: Console.Write("Two"); break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four"); break;
                    case 5: Console.Write("Five"); break;
                    case 6: Console.Write("Six"); break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine"); break;
                    default:
                        break;
                }
                Console.Write(" hundred");
                if (tenths == 0 && ones == 0)
                {
                    Console.WriteLine();

                }
                else if (tenths < 2)
                {
                    int underHundreds = n % 100;
                    Console.Write(" and ");
                    switch (underHundreds)
                    {
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;
                        case 10: Console.WriteLine("ten"); break;
                        case 11: Console.WriteLine("eleven"); break;
                        case 12: Console.WriteLine("twelve"); break;
                        case 13: Console.WriteLine("thirteen"); break;
                        case 14: Console.WriteLine("fourteen"); break;
                        case 15: Console.WriteLine("fifteen"); break;
                        case 16: Console.WriteLine("sixteen"); break;
                        case 17: Console.WriteLine("seventeen"); break;
                        case 18: Console.WriteLine("eighteen"); break;
                        case 19: Console.WriteLine("nineteen"); break;
                        
                    }
                }
                else
                {
                    Console.Write(" and ");
                    switch (tenths)
                    {
                        case 2: Console.Write("twenty"); break;
                        case 3: Console.Write("thirty"); break;
                        case 4: Console.Write("fourty"); break;
                        case 5: Console.Write("fifty"); break;
                        case 6: Console.Write("sixty"); break;
                        case 7: Console.Write("seventy"); break;
                        case 8: Console.Write("eighty"); break;
                        case 9: Console.Write("ninety"); break;
                        default:
                            break;
                    }
                    switch (ones)
                    {
                        case 0: Console.WriteLine(""); break;
                        case 1: Console.WriteLine("-one"); break;
                        case 2: Console.WriteLine("-two"); break;
                        case 3: Console.WriteLine("-three"); break;
                        case 4: Console.WriteLine("-four"); break;
                        case 5: Console.WriteLine("-five"); break;
                        case 6: Console.WriteLine("-six"); break;
                        case 7: Console.WriteLine("-seven"); break;
                        case 8: Console.WriteLine("-eight"); break;
                        case 9: Console.WriteLine("-nine"); break;
                        default:
                            break;
                    }
                }
               
            }
            else
            {
                Console.WriteLine("Number is too big.");
            }
            
        }
    }
}
