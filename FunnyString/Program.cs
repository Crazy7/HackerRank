using System;
class Solution
{
    static void Main(String[] args)
    {
        var caseCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < caseCount; i++)
        {
            var cur = Console.ReadLine();
            var ret = IsFunny(cur);

            var msg = ret ? "Funny" : "Not Funny";
            Console.WriteLine(msg);
        }
    }

    private static bool IsFunny(string str)
    {
        var len = str.Length;

        for (int i = 1; i < len; i++)
        {
            var a = str[i] - str[i - 1];
            var b = str[len - 1 - i] - str[len - i];

            if (Math.Abs(a) != Math.Abs(b)) return false;
        }

        return true;
    }
}