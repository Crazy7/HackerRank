using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var N = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var max = Solve(numbers);

        Console.WriteLine(max);
    }

    static int Solve(int[] numbers)
    {
        var stack = new Stack<Plant>();

        var max = 0;
        foreach (var n in numbers)
        {
            var daysAlive = 0;
            while (stack.Any() && n <= stack.Peek().Pesticide)
            {
                daysAlive = Math.Max(daysAlive, stack.Pop().Days);
            }

            if (stack.Any()) daysAlive++;
            else daysAlive = 0;

            max = Math.Max(max, daysAlive);
            stack.Push(new Plant(n, daysAlive));
        }

        return max;
    }
}

class Plant
{
    public int Pesticide { get; set; }

    public int Days { get; set; }

    public Plant(int pesticide, int days)
    {
        Pesticide = pesticide;
        Days = days;
    }
}