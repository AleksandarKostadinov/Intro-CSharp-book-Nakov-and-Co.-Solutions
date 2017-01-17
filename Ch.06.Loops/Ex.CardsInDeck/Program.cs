using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.CardsInDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] suits = { "clubs", "diamonds", "hearts", "spades" };
            string[] ranks = {"Ace" , "One" , "Two" , "Three" , "Four" , "Five" , "Six" , "Seven" , "Eight"
            , "Nine" , "Ten" , "Jack" , "Queen" , "King"};
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    Console.WriteLine("{0} of {1}", rank,suit);
                }
            }
        }
    }
}
