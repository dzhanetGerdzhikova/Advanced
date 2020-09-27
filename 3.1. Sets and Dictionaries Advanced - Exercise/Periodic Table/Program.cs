using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < countLines; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int el = 0; el < input.Length; el++)
                {
                    elements.Add(input[el]);
                }
            }
            foreach (var el in elements)
            {
                Console.Write(el + " ");
            }
        }
    }
}