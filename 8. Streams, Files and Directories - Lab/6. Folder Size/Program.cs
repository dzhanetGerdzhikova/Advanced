using System;
using System.IO;

namespace _6._Folder_Size
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Directory.GetFiles(@".");
            double sum = 0;

            foreach (var currWord in input)
            {
                FileInfo fileInfo = new FileInfo(currWord);

                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;
            Console.WriteLine($"{sum:f4}");
            File.WriteAllText("Output.txt", sum.ToString("F4"));
        }
    }
}