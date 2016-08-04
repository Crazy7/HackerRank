using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var NAndQ = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var N = NAndQ[0];
        var Q = NAndQ[1];

        var list = GenerateList(N);

        var lastAns = 0;
        for (var i = 0; i < Q; i++)
        {
            var query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (query[0] == 1)
            {
                Query1(list, query[1], query[2], lastAns);
            }
            else
            {
                Query2(list, query[1], query[2], ref lastAns);
            }
        }
    }

    private static IList<List<int>> GenerateList(int n)
    {
        return Enumerable.Range(1, n).Select(_ => new List<int>()).ToList();
    }

    private static void Query1(IList<List<int>> seqList, int x, int y, int lastAns)
    {
        var seqIndex = (x ^ lastAns) % seqList.Count;
        seqList[seqIndex].Add(y);
    }

    private static void Query2(IList<List<int>> seqList, int x, int y, ref int lastAns)
    {
        var seqIndex = (x ^ lastAns) % seqList.Count;
        var seq = seqList[seqIndex];
        var seqSize = seq.Count;
        lastAns = seq[y % seqSize];

        Console.WriteLine(lastAns);
    }
}