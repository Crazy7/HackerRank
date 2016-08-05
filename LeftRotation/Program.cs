using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        var NAndD = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        LeftRotate(array, NAndD[1]);
    }

    private static void LeftRotate(int[] a, int d)
    {
        var n = a.Length;
        if (d < n)
        {
            for (int i = d; i < n; i++) Console.Write(a[i] + " ");
            for (int i = 0; i < d; i++) Console.Write(a[i] + " ");
        }
        else
        {
            for (int i = n - 1; i >= 0; i--) Console.Write(a[i] + " ");
        }

    }
}