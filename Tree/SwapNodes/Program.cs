using System;
using System.Linq;

//Url : https://www.hackerrank.com/challenges/swap-nodes-algo
//Based on http://codereview.stackexchange.com/questions/91563/swap-nodes-in-a-binary-tree

public class Solution
{
    private const int RootNodeValue = 1;

    public static void Main(string[] args)
    {
        var n = ReadIntFromNextLine();
        var dataSource = new int[n + RootNodeValue][];

        for (int i = RootNodeValue; i < n + RootNodeValue; i++)
        {
            var curLR = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            dataSource[i] = curLR;
        }

        int depthCount = ReadIntFromNextLine();
        for (int i = 0; i < depthCount; i++)
        {
            Swap(dataSource, RootNodeValue, ReadIntFromNextLine(), 1);
            Console.WriteLine();
        }
    }

    private static int ReadIntFromNextLine()
    {
        return int.Parse(Console.ReadLine());
    }

    public static void Swap(int[][] dataSource, int node, int targetDepth, int depth)
    {
        if (node == -1) return;

        if (depth % targetDepth == 0)
        {
            int temp = dataSource[node][0];
            dataSource[node][0] = dataSource[node][1];
            dataSource[node][1] = temp;
        }

        Swap(dataSource, dataSource[node][0], targetDepth, depth + 1);
        Console.Write(node + " ");
        Swap(dataSource, dataSource[node][1], targetDepth, depth + 1);
    }
}