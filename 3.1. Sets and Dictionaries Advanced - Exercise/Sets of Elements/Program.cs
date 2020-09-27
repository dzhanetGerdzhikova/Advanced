using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] countInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstSet = countInput[0];
            int secondSet = countInput[1];

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            for (int i = 0; i < firstSet; i++)
            {
                int number = int.Parse(Console.ReadLine());
                first.Add(number);
            }

            for (int i = 0; i < secondSet; i++)
            {
                int number = int.Parse(Console.ReadLine());
                second.Add(number);
            }

            foreach (var el in first)
            {
                if (second.Contains(el))
                {
                    Console.Write(el + " ");
                }
            }
        }
    }
}