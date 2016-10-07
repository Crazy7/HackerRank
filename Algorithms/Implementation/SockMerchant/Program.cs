using System;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var c = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var ret = c.GroupBy(_ => _).Select(_ => _.Count()).Where(_ => _ > 1).Select(_ => _ / 2).Sum();

        Console.WriteLine(ret);
    }
}
