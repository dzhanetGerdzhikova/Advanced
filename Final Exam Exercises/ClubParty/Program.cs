using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            Stack<string> stack = new Stack<string>(input);
            Queue<char> halls = new Queue<char>();
            Dictionary<char, List<int>> hallsDict = new Dictionary<char, List<int>>();

            while (stack.Any())
            {
                string currentElement = stack.Pop();
                bool isDigit = int.TryParse(currentElement, out int people);
                if (isDigit && halls.Count == 0)
                {
                    continue;
                }
                else if (isDigit && halls.Count > 0)
                {
                    ChechHallCapacity(maxCapacity, halls, hallsDict, people);
                }
                else if (!isDigit)
                {
                    halls.Enqueue(char.Parse(currentElement));
                    hallsDict.Add(char.Parse(currentElement), new List<int>());
                }
            }
        }

        private static void ChechHallCapacity(int maxCapacity, Queue<char> halls, Dictionary<char, List<int>> hallsDict, int people)
        {
            var currentHall = halls.Peek();

            if (hallsDict[currentHall].Sum() + people < maxCapacity)
            {
                hallsDict[currentHall].Add(people);
            }
            else if (hallsDict[currentHall].Sum() + people == maxCapacity)
            {
                hallsDict[currentHall].Add(people);
                Console.WriteLine($"{currentHall} -> {string.Join(", ", hallsDict[currentHall])}");
                halls.Dequeue();
            }
            else
            {
                Console.WriteLine($"{currentHall} -> {string.Join(", ", hallsDict[currentHall])}");
                halls.Dequeue();
                if (halls.Count > 0)
                {
                    ChechHallCapacity(maxCapacity, halls, hallsDict, people);
                }
            }
        }
    }
}