using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();

            for (int i = 0; i < inputText.Length; i++)
            {
                if (!charsCount.ContainsKey(inputText[i]))
                {
                    charsCount.Add(inputText[i], 0);
                }
                charsCount[inputText[i]]++;
            }

            foreach (var el in charsCount)
            {
                Console.WriteLine($"{el.Key}: {el.Value} time/s");
            }
        }
    }
}