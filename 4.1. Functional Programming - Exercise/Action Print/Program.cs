using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_Print
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();

            Action<string> print = x => Console.WriteLine(x);

            names.ForEach(print);
        }
    }
}