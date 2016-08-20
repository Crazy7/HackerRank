using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = arr_temp.Select(int.Parse).ToArray();

        int positive = 0, negative = 0, zero = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            var cur = arr[i];

            if (cur > 0) positive++;
            else if (cur < 0) negative++;
            else zero++;
        }

        var positiveScale = ((decimal)positive) / n;
        var negativeScale = ((decimal)negative) / n;
        var zeroScale = ((decimal)zero) / n;

        var scales = new[] { positive, negative, zero }.Select(_ => (decimal)_).Select(_ => _ / n);
        foreach (var s in scales)
        {
            Console.WriteLine(s.ToString("N6"));
        }
    }
}
