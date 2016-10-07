//URL : https://www.hackerrank.com/challenges/maximum-perimeter-triangle

using System;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse)
                             .OrderByDescending(_ => _).ToArray();

        if (n < 3)
        {
            Console.WriteLine(-1);
            return;
        }

        for (var i = 0; i < n - 2; i++)
        {
            if(numbers[i] < numbers[i+1] + numbers[i+2])
            {
                var output = $"{numbers[i+2]} {numbers[i+1]} {numbers[i]}";
                Console.WriteLine(output);
                return;
            }
        }
        
        Console.WriteLine(-1);
    }
}