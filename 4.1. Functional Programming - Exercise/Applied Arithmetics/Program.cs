using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            Func<List<int>, List<int>> addNum = x => x.Select(y => y + 1).ToList();
            Func<List<int>, List<int>> multiolyNum = x => x.Select(y => y * 2).ToList();
            Func<List<int>, List<int>> subtractNum = x => x.Select(y => y - 1).ToList();
            Action<List<int>> print = x => Console.WriteLine(string.Join(' ', x));

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = addNum(numbers);
                        break;

                    case "multiply":
                        numbers = multiolyNum(numbers);
                        break;

                    case "subtract":
                        numbers = subtractNum(numbers);
                        break;

                    case "print":
                        print(numbers);
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            //Console.WriteLine(string.Join(' ',numbers));
        }
    }
}