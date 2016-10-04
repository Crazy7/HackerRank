using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var max = 0;
        var stack = new Stack<int>(n);

        for (var i = 0; i <= a.Count; i++)
        {
            if (i < a.Count && (!stack.Any() || a[i] > stack.Peek()))
            {
                stack.Push(a[i]);
                Console.WriteLine($"push {a[i]} to stack");
            }
            else
            {
                if (stack.Any())
                {
                    var lastValue = stack.Pop();
                    if (stack.Any())
                    {
                        max = Math.Max(max, (lastValue ^ stack.Peek()));

                        Console.WriteLine($"Max : {max}");
                    }
                    
                    i--;
                }

                
            }
        }

        stack.Clear();
        a.Insert(0, 0);

        for (var i = a.Count - 1; i >= 0; i--)
        {
            if (!stack.Any() || a[i] > stack.Peek())
            {
                stack.Push(a[i]);
                Console.WriteLine($"push {a[i]} to stack");
            }
            else
            {
                if (stack.Any())
                {
                    var lastValue = stack.Pop();
                    if (stack.Any())
                    {
                        max = Math.Max(max, (lastValue ^ stack.Peek()));
                        Console.WriteLine($"Max : {max}");
                    }
                    
                    i++;
                }
            }
        }

        Console.WriteLine(max);
    }
}