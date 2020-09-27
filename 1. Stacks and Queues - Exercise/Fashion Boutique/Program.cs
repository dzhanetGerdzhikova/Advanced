using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacityOrRack = int.Parse(Console.ReadLine());
            int countOfRacks = 1;
            int currentCapacity = capacityOrRack;

            while (clothes.Count > 0)
            {
                int currentCloth = clothes.Peek();
                if (currentCloth < currentCapacity)
                {
                    clothes.Pop();
                    currentCapacity -= currentCloth;
                }
                else if (currentCloth == currentCapacity)
                {
                    clothes.Pop();
                    currentCapacity -= currentCloth;
                    if (clothes.Any())
                    {
                        countOfRacks++;
                        currentCapacity = capacityOrRack;
                    }
                }
                else
                {
                    countOfRacks++;
                    currentCapacity = capacityOrRack;
                }
            }
            Console.WriteLine(countOfRacks);
        }
    }
}