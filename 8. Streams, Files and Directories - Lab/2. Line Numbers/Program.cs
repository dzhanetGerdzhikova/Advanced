using System.IO;

namespace _2._Line_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using StreamReader stream = new StreamReader(@"C:\Users\viole\source\repos\Advanced - Streams, Files and Directories - Lab\TextFile1.txt");
            using StreamWriter writer = new StreamWriter("AnotherFile.txt");

            int counter = 1;

            while (true)
            {
                string line = stream.ReadLine();
                if (line == null)
                {
                    break;
                }
                writer.WriteLine($"{counter}. {line}");
                counter++;
            }
        }
    }
}