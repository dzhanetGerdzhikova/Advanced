using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] rangeOfList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int startNum = rangeOfList[0];
            int endNum = rangeOfList[1];

            List<int> numbers = new List<int>();

            string typeNum = Console.ReadLine();

            Predicate<int> predicat = x => typeNum == "even" ? x % 2 == 0 : x % 2 != 0;

            for (int i = startNum; i <= endNum; i++)
            {
                numbers.Add(i);
            }

            numbers.Where(x => predicat(x)).ToList().ForEach(x => Console.Write($"{x} "));
        }
    }
}