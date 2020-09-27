using System;
using System.Linq;

namespace GenericSwapMethodInteger
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            SwapableElements<int> obekt = new SwapableElements<int>();

            for (int i = 0; i < countLines; i++)
            {
                int number = int.Parse(Console.ReadLine());
                obekt.Infos.Add(number);
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            obekt.Swap(indexes[0], indexes[1]);
            Console.WriteLine(obekt);
        }
    }
}