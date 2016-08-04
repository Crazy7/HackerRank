using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MarkAndToys(args);
        }

        static void MarkAndToys(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            var NKPair = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var toyPrices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            var toyCount = NKPair[0];
            if (toyCount != toyPrices.Length)
            {
                Console.WriteLine("Expected count : {0}, real count : {1}", toyCount, toyPrices.Length);
            }

            var money = NKPair[1];
            var buyableCount = 0;

            foreach (var i in toyPrices.OrderBy(_ => _))
            {
                money -= i;

                if (money >= 0)
                {
                    buyableCount++;

                    Console.WriteLine(i);
                }
                else break;
            }

            Console.WriteLine(buyableCount);
        }
    }
}
