using System;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var nkq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var n = nkq[0];
        var k = nkq[1];
        if (k > n) k = k % n;

        if (k < n) a = Rotate(a, k);

        var q = nkq[2];
        for (int i = 0; i < q; i++)
        {
            var cur = int.Parse(Console.ReadLine());
            var val = a[cur];

            Console.WriteLine(val);
        }
    }

    private static int[] RotateSlow(int[] a)
    {
        var n = a.Length;
        var dest = new int[n];

        dest[0] = a[n - 1];
        Array.Copy(a, 0, dest, 1, n - 1);

        return dest;
    }

    private static int[] Rotate(int[] a, int k)
    {
        var n = a.Length;
        var dest = new int[n];

        Array.Copy(a, n - k, dest, 0, k);
        Array.Copy(a, 0, dest, k, n - k);

        return dest;
    }
}