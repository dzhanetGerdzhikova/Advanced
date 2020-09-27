using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int wastedWater = 0;

            int currentCup = cups.Peek();

            while (cups.Any() && bottles.Any())
            {
                int currentBottle = bottles.Pop();

                if (currentCup <= currentBottle)
                {
                    currentBottle -= currentCup;
                    wastedWater += currentBottle;

                    cups.Dequeue();

                    if (cups.Count > 0)
                    {
                        currentCup = cups.Peek();
                    }
                }
                else
                {
                    currentCup -= currentBottle;
                }
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}