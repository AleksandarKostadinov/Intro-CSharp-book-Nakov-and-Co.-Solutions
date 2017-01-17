using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._11_IsoscelesTriangel
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = int.Parse(Console.ReadLine());

            char copyRights = '\u00A9';
            int emptySpaceCount = parameter-1;
            Console.WriteLine("{0}{1}{0}",new string(' ',parameter),copyRights);
            for (int rows = 0; rows < parameter-1; rows++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",new string(' ',emptySpaceCount--),copyRights,new string(' ',rows*2+1));
            }
            
            Console.WriteLine(new string(copyRights,parameter*2+1));
        }
    }
}
