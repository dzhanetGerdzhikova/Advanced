using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int addEl = commands[0];
            int removeEl = commands[1];
            int containsNum = commands[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int min = int.MaxValue;
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < addEl; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < removeEl; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(containsNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    foreach (var el in queue)
                    {
                        if (el < min)
                        {
                            min = el;
                        }
                    }
                    Console.WriteLine(min);
                }
            }
        }
    }
}