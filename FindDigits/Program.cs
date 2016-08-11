using System;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var ret = FindDigits(n);
            Console.WriteLine(ret);
        }
    }

    private static int FindDigits(int n)
    {
        return n.ToString().ToCharArray()
                .Where(_ => _ != '0')
                .Select(_ => _.ToString())
                .Select(int.Parse)
                .Where(_ => n % _ == 0).Count();
    }
}
