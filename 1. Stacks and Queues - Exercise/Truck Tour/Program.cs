using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countPumps = int.Parse(Console.ReadLine());
            Queue<int> result = new Queue<int>();

            for (int i = 0; i < countPumps; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int litters = input[0];
                int distance = input[1];

                result.Enqueue(litters - distance);
            }
            Queue<int> tempResult = new Queue<int>(result);
            int counter = 0;
            int sumResult = 0;
            while (tempResult.Any())
            {
                sumResult += tempResult.Dequeue();
                if (sumResult < 0)
                {
                    counter++;
                    result.Enqueue(result.Dequeue());
                    tempResult = new Queue<int>(result);
                    sumResult = 0;
                }
            }

            Console.WriteLine(counter);
        }
    }
}