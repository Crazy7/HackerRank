using System;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var a = Console.ReadLine();
        var b = Console.ReadLine();

        var ret = MakeByDeletions(a, b);
        Console.WriteLine(ret);
    }

    private static int MakeByDeletions(string a, string b)
    {
        var diffCount = 0;
        var aStatics = a.GroupBy(_ => _).ToDictionary(_ => _.Key, _ => _.Count());
        var bStatics = b.GroupBy(_ => _).ToDictionary(_ => _.Key, _ => _.Count());

        foreach (var p in aStatics)
        {
            var countInAnother = 0;

            var curDiffCount = bStatics.TryGetValue(p.Key, out countInAnother)
                ? Math.Max(0, p.Value - countInAnother)
                : p.Value;

            diffCount += curDiffCount;
        }

        foreach (var p in bStatics)
        {
            var countInAnother = 0;

            var curDiffCount = aStatics.TryGetValue(p.Key, out countInAnother)
                ? Math.Max(0, p.Value - countInAnother)
                : p.Value;

            diffCount += curDiffCount;
        }

        return diffCount;
    }
}