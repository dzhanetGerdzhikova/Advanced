using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] quantityOnOrder = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(quantityOnOrder);
            Queue<int> notCompletedOrders = new Queue<int>();

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                int currentOrder = queue.Peek();
                if (currentOrder <= quantityOfFood)
                {
                    queue.Dequeue();
                    quantityOfFood -= currentOrder;
                }
                else
                {
                    notCompletedOrders.Enqueue(currentOrder);
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    break;
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}