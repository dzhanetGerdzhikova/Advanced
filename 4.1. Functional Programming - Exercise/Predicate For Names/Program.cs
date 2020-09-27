using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_For_Names
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int lengthOfName = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(' ').ToList();

            Func<List<string>, List<string>> namesWihtLength = x => x.Where(y => y.Length <= lengthOfName).ToList();
            //Action<List<string>> namesWihtLengthAction = x => x = x.Where(y => y.Length <= lengthOfName).ToList();

            names = namesWihtLength(names);
            //namesWihtLength(names);

            Console.WriteLine(string.Join(Environment.NewLine, names)); ;
        }
    }
}