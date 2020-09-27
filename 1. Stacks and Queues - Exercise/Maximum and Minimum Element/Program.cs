using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < countLines; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = input[0];
                if (command == 1)
                {
                    int element = input[1];
                    numbers.Push(element);
                }
                else if (command == 2)
                {
                    numbers.Pop();
                }
                else if (command == 3)
                {
                    if (numbers.Count != 0)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (command == 4)
                {
                    if (numbers.Count != 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}