using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string number = Console.ReadLine();

        var isOddCount = n % 2 == 1;

        var leftLastIndex = (n / 2) - 1;

        var charArray = number.ToCharArray();
        var changeCount = 0;

        for (var i = 0; i <= leftLastIndex; i++)
        {
            var leftIndex = leftLastIndex - i;
            var rightIndex = leftLastIndex + i + 1 + (isOddCount ? 1 : 0);
            if (number[leftIndex] != number[rightIndex])
            {
                charArray[rightIndex] = number[leftIndex];

                changeCount++;
            }

            if (changeCount > k)
            {
                Console.WriteLine("-1");
                return;
            }
        }

        if (k > changeCount)
        {
            var remains = k - changeCount;
            var allowChangeIndics = charArray.Where(_ => _ != '9').Select((_v, _i) => _i).ToArray();

            for (int i = 0; i < remains / 2; i++)
            {
                var index = allowChangeIndics[i];
                charArray[index] = charArray[n - 1 - index] = '9';
            }
        }

        Console.WriteLine(new string(charArray));
    }
}
