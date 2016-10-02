using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var N = int.Parse(Console.ReadLine());
        var hist = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var max = ComputeLargetArea(hist);
        Console.WriteLine(max);
    }

    static int ComputeStack(int[] hist, Stack<int> stack, int max, int index)
    {
        var heightIndex = stack.Pop();

        var depth = index;
        if (stack.Any())
        {
            depth = index - stack.Peek() - 1;
        }

        var area = hist[heightIndex] * depth;
        max = Math.Max(area, max);

        return max;
    }

    static int ComputeLargetArea(int[] hist)
    {
        var stack = new Stack<int>();
        var max = 0;

        var i = 0;
        while (i < hist.Length)
        {
            if (!stack.Any() || hist[stack.Peek()] <= hist[i])
            {
                stack.Push(i);
                i++;
            }
            else
            {
                max = ComputeStack(hist, stack, max, i);
            }
        }

        while (stack.Any())
        {
            max = ComputeStack(hist, stack, max, i);
        }

        return max;
    }
}