using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._9_Quoted_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The \"use\" of quotations causes deffeculties";
            string sentence2=@"The ""use"" of quotations causes deffeculties";
            Console.WriteLine(sentence);
            Console.WriteLine(sentence2);
        }
    }
}
