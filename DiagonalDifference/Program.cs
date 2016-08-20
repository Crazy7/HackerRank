using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for (int a_i = 0; a_i < n; a_i++)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            a[a_i] = a_temp.Select(Int32.Parse).ToArray();
        }

        CalcDiff(a);
    }

    private static void CalcDiff(int[][] a)
    {
        var n = a.Length;

        var primary = 0;
        for (int i = 0; i < n; i++)
        {
            primary += a[i][i];
        }

        var secordary = 0;
        for (int i = 0; i < n; i++)
        {
            secordary += a[n - 1 - i][i];
        }

        var ret = Math.Abs(primary - secordary);

        Console.WriteLine(ret);
    }
}
