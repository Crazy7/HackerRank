using System;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var x = A.Select((_v, _i) => new { V = _v, I = _i })
                    .GroupBy(_ => _.V)
                    .Where(_ => _.Count() > 1)
                    .Select(_ => _.Select(_p => _p.I).OrderBy(__ => __).ToArray())
                    .SelectMany(CalculateDistances)
                    .ToArray();

        if (x.Any()) Console.WriteLine(x.Min());
        else Console.WriteLine(-1);
    }

    private static int[] CalculateDistances(int[] a)
    {
        if (a.Length < 2) return a;

        return Enumerable.Range(1, a.Length - 1).Select(_ => Math.Abs(a[_] - a[_ - 1])).ToArray();
    }
}
