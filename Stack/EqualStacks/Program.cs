using System;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        Console.ReadLine(); //skip first line;

        var h1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var h2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var h3 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var stacks = new[]{ h1, h2, h3}.Select(_=> new MyStack(_)).ToArray();
        MyStack.PopAll(stacks);

        Console.WriteLine(stacks.First().Sum);
    }
}

class MyStack
{
    private int[] _data;

    private int _index;

    public int Sum { get; private set; }

    public MyStack(int[] data)
    {
        _data = data ?? new int[0];
        _index = 0;

        Sum = _data.Sum();
    }

    public void Pop()
    {
        Sum -= _data[_index++];
    }

    public static void PopAll(MyStack[] stacks)
    {
        if (!stacks.Any() || stacks.Length == 1) return;

        while (true)
        {
            for (var i = 0; i < stacks.Length; i++)
            {
                var curStack = stacks[i];
                if (stacks.Where((v, _i) => _i != i && curStack.Sum > v.Sum).Any())
                {
                    curStack.Pop();
                }
            }

            if (stacks.All(_ => _.Sum == stacks.First().Sum)) break;
        }
    }
}
