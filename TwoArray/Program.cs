using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        TwoArrays(args);
    }


    static void TwoArrays(String[] args)
    {
        var caseCount = int.Parse(Console.ReadLine());

        for (var i = 0; i < caseCount; i++)
        {
            var arrayLengthAndK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = arrayLengthAndK[1];

            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            TwoArrays_Single(a, b, k);
        }
    }

    static void TwoArrays_Single(int[] a, int[] b, int k)
    {
        Array.Sort(a);

        Array.Sort(b);
        Array.Reverse(b);

        var isOk = true;
        for (var i = 0; i < a.Length; i++)
        {
            if (a[i] + b[i] < k)
            {
                isOk = false;
                break;
            }
        }

        var msg = isOk ? "YES" : "NO";

        Console.WriteLine(msg);
    }
}