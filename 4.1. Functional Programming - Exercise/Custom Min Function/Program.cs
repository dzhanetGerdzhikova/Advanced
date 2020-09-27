using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Func<List<int>, int> smallestNum = x =>
            {
                int minNum = int.MaxValue;

                foreach (var currentNum in numbers)
                {
                    if (currentNum <= minNum)
                    {
                        minNum = currentNum;
                    }
                }
                return minNum;
            };

            int resultNumber = smallestNum(numbers);
            Console.WriteLine(resultNumber);
        }
    }
}