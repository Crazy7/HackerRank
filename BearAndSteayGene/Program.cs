using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        //read count;
        Console.ReadLine();

        var str = Console.ReadLine();

        var ret = Calculate(str);
        Console.WriteLine(ret);
    }

    public static int Calculate(string s)
    {
        var n = s.Length;
        var maxOccurrences = n / 4;
        var cnt = new int[256];
        foreach (char c in s) cnt[c]++;

        if (!cnt.Any(_ => _ > maxOccurrences)) return 0;

        return GetMinimumLength(cnt, n, maxOccurrences, s);
    }

    private static int GetMinimumLength(int[] cnt, int n, int mx, string s)
    {
        int endIndex = 0;
        int ret = n;

        var chars = new[] { 'A', 'C', 'G', 'T' };
        for (int startIndex = 0; startIndex < n; startIndex++)
        {
            while (chars.Any(_ => cnt[_] > mx))
            {
                if (endIndex == n) return ret;

                --cnt[s[endIndex]];
                ++endIndex;
            }

            ret = Math.Min(ret, endIndex - startIndex);
            ++cnt[s[startIndex]];
        }

        return ret;
    }
}