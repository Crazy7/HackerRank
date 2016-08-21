using System;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = arr_temp.Select(int.Parse).ToArray();

        const int max = 1000;
        var map = new int[max];
        for (var i = 0; i < max; i++) map[i] = 0;
        for (var i = 0; i < n; i++)
        {
            var x = i;
            var v = arr[x];
            map[v]++;
        }
        Console.WriteLine(n);
        for (var i = 0; i < max; i++)
        {
            var cur = map[i];
            if (cur == 0) continue;

            n -= cur;

            if (n > 0) Console.WriteLine(n);

        }
    }
}
