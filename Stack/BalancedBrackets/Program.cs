using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var cur = Console.ReadLine();
                var msg = Valid(cur) ? "YES" : "NO";
                Console.WriteLine(msg);
            }
        }

        private static bool Valid(string s)
        {
            var map = new Dictionary<char, char>
            {
                ['}'] = '{',
                [']'] = '[',
                [')'] = '('
            };

            var leftChars = map.Values.ToArray();
            var rightChars = map.Keys.ToArray();

            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (leftChars.Contains(c))
                {
                    stack.Push(c);
                }

                else if (rightChars.Contains(c))
                {
                    if (stack.Count == 0 || stack.Pop() != map[c])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
