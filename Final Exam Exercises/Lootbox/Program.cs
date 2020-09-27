using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> firstBox = new Queue<int>(firstLine);
            Stack<int> secondtBox = new Stack<int>(secondLine);
            List<int> numbers = new List<int>();

            while (firstBox.Any() && secondtBox.Any())
            {
                int firstNum = firstBox.Peek();
                int secondNum = secondtBox.Peek();
                int sum = firstNum + secondNum;

                if (sum % 2 == 0)
                {
                    firstBox.Dequeue();
                    secondtBox.Pop();
                    numbers.Add(sum);
                }
                else
                {
                    secondtBox.Pop();
                    firstBox.Enqueue(secondNum);
                }
            }
            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (secondtBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (numbers.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {numbers.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {numbers.Sum()}");
            }
        }
    }
}