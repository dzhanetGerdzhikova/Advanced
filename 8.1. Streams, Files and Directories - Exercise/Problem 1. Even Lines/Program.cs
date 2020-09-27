using System;
using System.IO;
using System.Linq;

namespace Problem_1._Even_Lines
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using StreamReader file = new StreamReader("text.txt");
            char[] punctuations = new char[] { '-', ',', '.', '!', '?' };
            int countLine = 0;

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();

                if (countLine % 2 == 0)
                {
                    string currentLine = string.Join(' ', line.Split(' ').Reverse());

                    foreach (var symbol in punctuations)
                    {
                        currentLine = currentLine.Replace(symbol, '@');
                    }
                    Console.WriteLine(currentLine);
                }
                countLine++;
            }
        }
    }
}