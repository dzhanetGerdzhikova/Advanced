using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, int, bool> sumOfOneName = (word, sum) => word.Sum(x => x) >= sum;

            Func<List<string>, Func<string, int, bool>, string> finalFunc = (names, isEqualOrLarger) => names.FirstOrDefault(x => isEqualOrLarger(x, sum));

            string finalName = finalFunc(names, sumOfOneName);
            Console.WriteLine(finalName);
        }
    }
}