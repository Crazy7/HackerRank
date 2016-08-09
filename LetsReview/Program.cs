using System;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var caseCount = int.Parse(Console.ReadLine());
        for (var i = 0; i < caseCount; i++)
        {
            var cur = Console.ReadLine();

            var evenSub = cur.Where((_v, _i) => _i % 2 == 0);
            var oddSub = cur.Where((_v, _i) => _i % 2 == 1);

            var ret = $"{string.Concat(evenSub)}  {string.Concat(oddSub)}";

            Console.WriteLine(ret);
        }
    }
}