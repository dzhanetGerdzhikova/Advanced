using System;
using System.IO;

namespace _1._Odd_Lines
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using StreamReader stream = new StreamReader(@"C:\Users\viole\source\repos\Advanced - Streams, Files and Directories - Lab\TextFile1.txt");
            int counter = 1;
            while (true)
            {
                string line = stream.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (counter % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                counter++;
            }
        }
    }
}