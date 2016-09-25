//URL : https://www.hackerrank.com/challenges/maximum-element

using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        V1();
    }

    static void V1()
    {
        var queryCount = int.Parse(Console.ReadLine());

        int max = int.MinValue;

        var stack = new Stack<MyStackItem>();
        for (var i = 0; i < queryCount; i++)
        {
            var curQuery = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var type = curQuery[0];
            if (type == 1)
            {
                var value = curQuery[1];

                max = Math.Max(value, max);
                stack.Push(new MyStackItem(value, max));
            }
            else if (type == 2)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }

                max = stack.Count > 0 ? stack.Peek().MaxValue : int.MinValue;
            }
            else if (type == 3)
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Peek().MaxValue);
                }
            }
        }
    }

    class MyStackItem
    {
        public int Value { get; private set; }
        public int MaxValue { get; private set; }

        public MyStackItem(int val, int curMax)
        {
            this.Value = val;
            this.MaxValue = curMax;
        }

    }

    ///this method will print correct answer, but it will timeout in hackerrank.
    static void V0()
    {
        var queryCount = int.Parse(Console.ReadLine());

        var stack = new MyIntStack(queryCount / 2);
        for (var i = 0; i < queryCount; i++)
        {
            var curQuery = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var type = curQuery[0];
            if (type == 1)
            {
                var value = curQuery[1];
                stack.Push(value);
            }
            else if (type == 2)
            {
                stack.Pop();
            }
            else if (type == 3)
            {
                var max = stack.Max();
                Console.WriteLine(max);
            }
        }
    }
}

class MyStack<T>
{
    private Stack<T> _collection;


    public MyStack(int capacity)
    {
        _collection = new Stack<T>(capacity);

    }

    public virtual void Push(T value)
    {
        _collection.Push(value);
    }

    public virtual T Max()
    {
        return _collection.Max();
    }

    public virtual T Pop()
    {
        var value = _collection.Pop();

        return value;
    }
}

class MyIntStack : MyStack<int>
{
    private List<int> _sorted;

    public MyIntStack(int capacity) : base(capacity)
    {
        _sorted = new List<int>();
    }

    public override void Push(int value)
    {
        base.Push(value);

        if (_sorted.Count == 0 || value > _sorted.Last())
        {
            _sorted.Add(value);
        }
        else
        {
            var insertIndex = 0;
            for (var i = 0; i < _sorted.Count; i++)
            {
                var cur = _sorted[i];
                if (cur >= value)
                {
                    insertIndex = i;
                    break;
                }
            }

            _sorted.Insert(insertIndex, value);
        }
    }

    public override int Pop()
    {
        var value = base.Pop();
        _sorted.Remove(value);

        return value;
    }

    public override int Max()
    {
        return _sorted.Any() ? _sorted.Last() : 0;
    }
}