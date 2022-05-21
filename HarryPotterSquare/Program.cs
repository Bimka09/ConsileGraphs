using System;
using System.IO;
using System.Linq;

namespace HarryPotterSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int x = 0; x < 25; x++)
            {
                for(int y = 0; y < 25; y++)
                {
                    Console.Write(
                        (x < y) ? "#" : ".");
                }
                Console.WriteLine();
            }
        }
    }
    // 1) (x < y) ? "#" : ".");
    // 2) (x == y) ? "#" : ".");
    // 3) (x == 24 - y) ? "#" : ".");
    // 4) 
    // 5) (2 * x == y | 2 * x + 1== y) ? "#" : ".");
    // 6) (x < 10 | y < 10) ? "#" : ".");
    // 7) (x > 15 & y > 15) ? "#" : ".");
    // 8) (x * y == 0) ? "#" : ".");

}
