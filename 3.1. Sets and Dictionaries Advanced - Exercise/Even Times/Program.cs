using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            Dictionary<int, int> numsCount = new Dictionary<int, int>();

            for (int i = 0; i < countLines; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!numsCount.ContainsKey(num))
                {
                    numsCount.Add(num, 0);
                }
                numsCount[num]++;
            }
            foreach (var num in numsCount.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(num.Key);
            }
        }
    }
}