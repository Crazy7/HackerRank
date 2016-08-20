using System;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int[][] arr = new int[6][];
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            arr[arr_i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        var half = 3;
        int? ret = null;

        for (int h = 0; h <= half; h++)
        {
            for (int v = 0; v <= half; v++)
            {
                var curSum = 0;
                for (int h_i = 0; h_i < 3; h_i++)
                {
                    for (int v_i = 0; v_i < 3; v_i++)
                    {
                        if (h_i == 1 && v_i == 0) continue;
                        if (h_i == 1 && v_i == 2) continue;

                        curSum += arr[h + h_i][v + v_i];
                    }
                }

                if (ret == null) ret = curSum;
                else ret = Math.Max(ret.Value, curSum);
            }
        }

        Console.WriteLine(ret);
    }
}
