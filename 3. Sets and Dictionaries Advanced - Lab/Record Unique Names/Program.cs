using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countInput = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < countInput; i++)
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