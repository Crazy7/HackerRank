using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var caseCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < caseCount; i++)
            {
                var @case = Console.ReadLine();
                var ret = Calculate(@case);

                Console.WriteLine(ret);
            }
        }

        private static int Calculate(string str)
        {
            var len = str.Length;
            if (len % 2 == 1) return -1;

            var halfIndex = str.Length / 2;
            var a = str.Substring(0, halfIndex);
            var b = str.Substring(halfIndex);

            var diffCount = 0;
            var aStatics = a.GroupBy(_ => _).ToDictionary(_ => _.Key, _ => _.Count());
            var bStatics = b.GroupBy(_ => _).ToDictionary(_ => _.Key, _ => _.Count());

            foreach(var p in aStatics)
            {
                var countInAnother = 0;
                if(bStatics.TryGetValue(p.Key, out countInAnother))
                {
                    //for characters exist in both of a and b, 
                    //if the count of char in a is less than count in b, just ignore it, because the Lengths between 2 arrays are equal 
                    diffCount+= Math.Max(0, p.Value - countInAnother);
                }
                else
                {
                    diffCount += p.Value;
                }
            }
            
            return diffCount;
        }
    }
}
