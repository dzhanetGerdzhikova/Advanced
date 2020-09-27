using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Of_Predicates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            List<int> divisibleNum = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1; i <= endOfRange; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isCorrectNum = x =>
            {
                foreach (var currentNum in divisibleNum)
                {
                    if (x % currentNum != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            //numbers.Where(x => isCorrectNum(x)).ToList().ForEach(y=>Console.Write(y+" "));
            numbers = numbers.Where(x => isCorrectNum(x)).ToList();
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}