using System;
class Solution
{
    static void Main(String[] args)
    {
        string S = Console.ReadLine();

        var changedCount = 0;
        for (var i = 0; i < S.Length; i += 3)
        {
            if (S[i] != 'S') changedCount++;
            if (S[i + 1] != 'O') changedCount++;
            if (S[i + 2] != 'S') changedCount++;
        }

        Console.WriteLine(changedCount);
    }
}
