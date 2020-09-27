using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_3._Word_Count
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] inputFile = File.ReadAllLines("text.txt");
            string[] wordsFile = File.ReadAllLines("words.txt");

            //File.WriteAllLines("expectedResult.txt",);

            Dictionary<string, int> countWords = new Dictionary<string, int>();

            for (int i = 0; i < inputFile.Length; i++)
            {
                string[] wordsInLine = inputFile[i].Split(new char[] { ' ', '-', ',', '!', '.', '?' });

                foreach (var searchWord in wordsFile)
                {
                    for (int j = 0; j < wordsInLine.Length; j++)
                    {
                        if (wordsInLine[j].ToLower() == searchWord.ToLower())
                        {
                            if (!countWords.ContainsKey(searchWord))
                            {
                                countWords[searchWord] = 0;
                            }
                            countWords[searchWord]++;
                        }
                    }
                }
            }

            List<string> result = new List<string>();

            foreach (var currWord in wordsFile)
            {
                if (countWords.ContainsKey(currWord))
                {
                    result.Add($"{currWord} - {countWords[currWord]}");
                }
                else
                {
                    result.Add($"{currWord} - 0");
                }
            }

            File.WriteAllLines("actualResults.txt", result);
            File.WriteAllLines("expectedResult.txt", countWords.OrderByDescending(e => e.Value).Select(e => $"{e.Key} - {e.Value}"));

            //Process.Start("notepad.exe", "actualResults.txt");
            //Process.Start("notepad.exe", "expectedResult.txt");
        }
    }
}