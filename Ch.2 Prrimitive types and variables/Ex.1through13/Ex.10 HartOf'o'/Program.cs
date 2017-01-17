using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10_HartOf_o_
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = int.Parse(Console.ReadLine());
            int heartWidth = 2 * parameter + (parameter - 1) * 3 + parameter  % 2;
            //Console.WriteLine(heartWidth);
            string heartUpperPart = new string('o', parameter);
            // ES - empty space
            int outsideESCount = parameter - 1;
            string outsideES = new string(' ',outsideESCount);
            int middleESCount;
            if (parameter%2==0)
            {
                middleESCount = parameter - 1;
                string middleES = new string(' ', middleESCount);
                Console.WriteLine("{0}{1}{2}{1}{0}",outsideES,heartUpperPart,middleES);
            }
            else
            {
                middleESCount = parameter ;
                string middleES = new string(' ', middleESCount);
                Console.WriteLine("{0}{1}{2}{1}{0}", outsideES, heartUpperPart, middleES);
            }
            int upperEggForCount = middleESCount/2;
            int insideESCount = parameter ;
            string insideES;
            for (int i = 0; i < upperEggForCount; i++)
            {
                middleESCount -= 2;
                insideES = new string(' ', insideESCount);
                string middleES = new string(' ', middleESCount);
                outsideES = new string(' ', --outsideESCount);
                Console.WriteLine("{0}o{1}o{2}o{1}o{0}",outsideES,insideES,middleES);
                insideESCount += 2;
            }
            
            insideES = new string(' ', insideESCount);
            outsideES = new string(' ', --outsideESCount);
            Console.WriteLine("{0}o{1}o{1}o{0}",outsideES,insideES);
            int middleESBodyCount = heartWidth - (parameter - (parameter - 1) / 2 - 2)*2;
            string middleESBody = new string(' ', middleESBodyCount);
            //for (int i = 0; i < middleESBodyCount; i++)
            //{
            //    string c = ""+i;
            //    
            //    Console.Write(c);
            //}
            //Console.WriteLine();
            for (int i = 0; i < (parameter-(parameter-1)/2-2); i++)
            {
                outsideES = new string(' ', --outsideESCount);
                middleESBody = new string(' ', middleESBodyCount);
                Console.WriteLine("{0}o{1}o{0}",outsideES,middleESBody);
                middleESBodyCount += 2;
            }
            //Console.WriteLine((parameter - (parameter - 1) / 2 - 2));
            for (int i = 0; i < parameter-2; i++)
            {
                Console.WriteLine("o{0}o",new string(' ',heartWidth-2));
            }
            middleESBodyCount -= 2;
            for (int i = 0; i <(heartWidth-1)/2; i++)
            {
                middleESBody = new string(' ', middleESBodyCount);
                Console.WriteLine("{0}o{1}o{0}",new string(' ',outsideESCount++),middleESBody);
                middleESBodyCount -= 2;
            }
            Console.WriteLine("{0}o{0}",new string(' ',(heartWidth-1)/2));
        }
    }
}
