using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var caseCount= int.Parse(Console.ReadLine());

        for (int i = 0; i < caseCount; i++)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();

            var hasSameSubString = HasSameSubString(a, b);
            var msg = hasSameSubString ? "YES" : "NO";

            Console.WriteLine(msg);
        }
    }

    private static bool HasSameSubString(string a, string b)
    {
        return a.Intersect(b).Count() > 0;
    }
}