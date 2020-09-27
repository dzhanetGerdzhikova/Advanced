using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Word_Count
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using StreamReader wordFile = new StreamReader("Word.txt");
            string[] line = wordFile.ReadToEnd().Split(' ').ToArray();

            using StreamReader inputFile = new StreamReader("Input.txt");
            string input = inputFile.ReadToEnd();

            Dictionary<string, int> counterWords = new Dictionary<string, int>();
            foreach (var item in line)
            {
                int matchCount = Regex.Matches(input.ToLower(), $@"\b{item.ToLower()}\b").Count();
                counterWords[item] = matchCount;
            }

            using StreamWriter writer = new StreamWriter("Output.txt");
            foreach (var item in counterWords.OrderByDescending(x => x.Value))
            {
                writer.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}