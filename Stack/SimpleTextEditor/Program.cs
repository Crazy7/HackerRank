using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    private static string S = string.Empty;
    private static Stack<OpRecord> stack = new Stack<OpRecord>();

    static void Main(String[] args)
    {
        var N = int.Parse(Console.ReadLine());

        for (var i = 0; i < N; i++)
        {
            var operation = Console.ReadLine().Split(' ');

            var type = int.Parse(operation[0]);

            if (type == 1)
            {
                Append(operation[1]);
            }
            else if (type == 2)
            {
                var k = int.Parse(operation[1]);
                Delete(k);
            }
            else if (type == 3)
            {
                var k = int.Parse(operation[1]);
                var sub = S[k - 1];

                Console.WriteLine(sub);
            }
            else if (type == 4)
            {
                if (stack.Any())
                {
                    var preOp = stack.Pop();

                    if (preOp.Type == 1) Delete(preOp.AffectedChars.Length, false);
                    else if (preOp.Type == 2) Append(preOp.AffectedChars, false);
                }
            }
        }
    }

    static void Append(string value, bool record = true)
    {
        S += value;

        if (record) stack.Push(new OpRecord { Type = 1, AffectedChars = value });
    }

    static void Delete(int k, bool record = true)
    {
        var sub = S.Substring(S.Length - k);
        S = S.Substring(0, S.Length - k);

        if (record) stack.Push(new OpRecord { Type = 2, AffectedChars = sub });
    }
}

class OpRecord
{
    public int Type { get; set; }

    public string AffectedChars { get; set; }
}