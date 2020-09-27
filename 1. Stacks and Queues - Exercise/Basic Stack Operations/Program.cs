using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countPushEl = commands[0];
            int countPopEl = commands[1];
            int containsNum = commands[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = int.MaxValue;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < countPushEl; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < countPopEl; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            if (stack.Contains(containsNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    foreach (var el in stack)
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