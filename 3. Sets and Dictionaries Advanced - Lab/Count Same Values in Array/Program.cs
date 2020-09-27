using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Dictionary<double, int> countNums = new Dictionary<double, int>();

            foreach (var num in input)
            {
                if (!countNums.ContainsKey(num))
                {
                    countNums.Add(num, 0);
                }
                countNums[num]++;
            }

            foreach (var kvp in countNums)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}