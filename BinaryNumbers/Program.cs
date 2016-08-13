using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        var binary = Convert.ToString(n, 2);

        var ret = 0;
        var i = 0;
        while (i < binary.Length)
        {
            var cur = binary[i];

            if (cur != '1')
            {
                i++;
                continue;
            }

            var j = i;
            var counter = 0;

            while (j < binary.Length)
            {
                if (binary[j] != '1') break;
                else counter++;

                j++;
            }

            ret = Math.Max(ret, counter);

            if (j > i) i = j;
            else i++;
        }

        Console.WriteLine(ret);
    }
}
