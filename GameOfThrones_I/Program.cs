using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var str = Console.ReadLine();

            var ret = IsPalindrome(str);
            var msg = ret ? "YES" : "NO";
            Console.WriteLine(msg);
        }

        private static bool IsPalindrome(string str)
        {
            return str.GroupBy(_ => _).Where(_ => _.Count() % 2 == 1).Count() <= 1;
        }
    }
}
