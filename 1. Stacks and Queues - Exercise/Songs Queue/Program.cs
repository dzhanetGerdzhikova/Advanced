using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(input);
            while (songs.Count > 0)
            {
                string lineCommand = Console.ReadLine();
                string[] splitedCommand = lineCommand.Split();
                string command = splitedCommand[0];
                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    string nameSong = lineCommand.Replace(command + " ", string.Empty);
                    if (songs.Contains(nameSong))
                    {
                        Console.WriteLine($"{nameSong} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(nameSong);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}