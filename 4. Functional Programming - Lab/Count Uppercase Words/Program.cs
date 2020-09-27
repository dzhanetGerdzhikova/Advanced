using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, bool> word = w => char.IsUpper(w[0]);
            input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(word).ToList().ForEach(Console.WriteLine);
        }
    }
}