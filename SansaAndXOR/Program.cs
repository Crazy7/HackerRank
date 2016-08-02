using System;
using System.Collections.Generic;
using System.Linq;

namespace HR_SansaAndXOR 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var caseCount = int.Parse(Console.ReadLine());

            var inputs = new List<int[]>(caseCount);
            for (var i = 0; i < caseCount; i++)
            {
                var curCount = int.Parse(Console.ReadLine());
                var curArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                inputs.Add(curArray);
            }

            foreach (var item in inputs)
            {
                ProcessSingle(item);
            }
        }

        private static void ProcessSingle(int[] array)
        {
            var r = Resolve(array);

            Console.WriteLine(r);
        }

        private static int Resolve(IList<int> collection)
        {
            var elementCount = collection.Count;
            var xor = 0;
            if ((elementCount & 1) == 1)
            {
                for (int i = 0; i < elementCount; i += 2)
                {
                    xor ^= collection[i];
                }
            }

            return xor;
        }
    }
}
