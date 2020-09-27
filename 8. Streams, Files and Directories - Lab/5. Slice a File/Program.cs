using System;
using System.IO;
using System.Linq;

namespace _5._Slice_a_File
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using FileStream readFile = new FileStream("TextFile1.txt", FileMode.OpenOrCreate);

            int parts = 4;

            long pieceSize = (long)Math.Ceiling((double)readFile.Length / parts);

            byte[] buffer = new byte[pieceSize];

            for (int i = 0; i < parts; i++)
            {
                int bytesRead = readFile.Read(buffer, 0, buffer.Length);

                if (bytesRead < buffer.Length)
                {
                    buffer = buffer.Take(bytesRead).ToArray();
                }

                using var currentNewFile = new FileStream($"Parth{i + 1}.txt", FileMode.Create);
                currentNewFile.Write(buffer, 0, buffer.Length);
            }
        }
    }
}