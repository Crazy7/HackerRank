using System;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_n1 = Console.ReadLine().Split(' ');
        int n1 = Convert.ToInt32(tokens_n1[0]);
        int n2 = Convert.ToInt32(tokens_n1[1]);
        int n3 = Convert.ToInt32(tokens_n1[2]);
        string[] h1_temp = Console.ReadLine().Split(' ');
        int[] h1 = ConvertAll(h1_temp, Int32.Parse);
        string[] h2_temp = Console.ReadLine().Split(' ');
        int[] h2 = ConvertAll(h2_temp, Int32.Parse);
        string[] h3_temp = Console.ReadLine().Split(' ');
        int[] h3 = ConvertAll(h3_temp, Int32.Parse);

        var sum1 = h1.Sum();
        var sum2 = h2.Sum();
        var sum3 = h3.Sum();

        var i1 = 0; var i2 = 0; var i3 = 0;

        while (true)
        {
            if (sum1 > sum2 || sum1 > sum3) sum1 -= h1[i1++];
            else if (sum2 > sum1 || sum2 > sum3) sum2 -= h2[i2++];
            else if (sum3 > sum1 || sum3 > sum2) sum3 -= h3[i3++];
            else break;
        }

        Console.WriteLine(sum1);
    }

    static int[] ConvertAll(string[] source, Func<string, int> func)
    {
        return source.Select(func).ToArray();
    }
}
