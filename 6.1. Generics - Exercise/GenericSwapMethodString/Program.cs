using System;
using System.Linq;

namespace GenericSwapMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            SwapableElements<string> obekt = new SwapableElements<string>();
            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();
                obekt.Inputs.Add(input);
            }

            int[] swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            obekt.Swap(swapIndexes[0], swapIndexes[1]);
            Console.WriteLine(obekt.ToString());
        }
    }
}