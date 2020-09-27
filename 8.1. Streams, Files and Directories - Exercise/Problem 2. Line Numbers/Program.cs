using System.IO;
using System.Linq;

namespace Problem_2._Line_Numbers
{
    internal class Programq
    {
        private static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                int letters = CountLetter(currentLine);
                int punctuations = CountPunctuations(currentLine);

                lines[i] = $"Line {i + 1}: {currentLine} ({letters})({punctuations})".TrimEnd();
            }
            File.WriteAllLines("output.txt", lines);
        }

        private static int CountLetter(string line)
        {
            char[] chars = line.ToCharArray();
            int counter = 0;

            foreach (var currChar in chars)
            {
                if (char.IsLetter(currChar))
                {
                    counter++;
                }
            }
            return counter;
        }

        private static int CountPunctuations(string line)
        {
            char[] chars = line.ToArray();
            int count = 0;

            foreach (var currchar in chars)
            {
                if (char.IsPunctuation(currchar))
                {
                    count++;
                }
            }
            return count;
        }
    }
}