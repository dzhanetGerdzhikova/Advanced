using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_And_Exclude
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int divNum = int.Parse(Console.ReadLine());

            Predicate<int> isDivisibleNum = x => x % divNum != 0;

            numbers = numbers.Where(x => isDivisibleNum(x)).ToList();
            numbers.Reverse();
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}