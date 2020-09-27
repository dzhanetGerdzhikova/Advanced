using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLine = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < countLine; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}