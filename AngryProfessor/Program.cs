using System;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = a_temp.Select(int.Parse).ToArray();

            var isOK = a.Count(_ => _ <= 0) >= k;
            var msg = isOK ? "NO" : "YES";
            Console.WriteLine(msg);
        }
    }
}
