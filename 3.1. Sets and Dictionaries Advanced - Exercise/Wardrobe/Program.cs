using System;
using System.Collections.Generic;

namespace Wardrobe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> allClothes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < countLines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!allClothes.ContainsKey(color))
                {
                    allClothes.Add(color, new Dictionary<string, int>());
                }

                foreach (var currItem in clothes)
                {
                    if (!allClothes[color].ContainsKey(currItem))
                    {
                        allClothes[color].Add(currItem, 0);
                    }
                    allClothes[color][currItem]++;
                }
            }
            string[] nextInput = Console.ReadLine().Split(' ');
            string searchColor = nextInput[0];
            string searchItem = nextInput[1];

            foreach (var (color, item) in allClothes)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var currItem in item)
                {
                    if (searchColor == color && searchItem == currItem.Key)
                    {
                        Console.WriteLine($"* {currItem.Key} - {currItem.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {currItem.Key} - {currItem.Value}");
                    }
                }
            }
        }
    }
}