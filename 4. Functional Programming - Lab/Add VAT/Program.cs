using System;
using System.Linq;

namespace Add_VAT
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, double> price = x => double.Parse(x) * 1.2;
            input.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(price).ToList().ForEach(x => Console.WriteLine($"{x:f2}"));
        }
    }
}