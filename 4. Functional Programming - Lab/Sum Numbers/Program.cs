using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, int> parse = n => int.Parse(n);

            List<int> numbers = input.Split(", ").Select(parse).ToList();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}
