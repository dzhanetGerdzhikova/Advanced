using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            string input = Console.ReadLine();

            string criteria = "";
            string info = "";
            Predicate<string> isCorrectName = x => criteria switch
              {
                  "StartsWith" => x.StartsWith(info),
                  "EndsWith" => x.EndsWith(info),
                  "Length" => x.Length == int.Parse(info),
                  _ => throw new NotImplementedException()
              };

            while (input != "Party!")
            {
                string[] splitedInput = input.Split(' ').ToArray();
                string command = splitedInput[0];
                criteria = splitedInput[1];
                info = splitedInput[2];

                if (command == "Remove")
                {
                    names.RemoveAll(isCorrectName);
                }
                else if (command == "Double")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (isCorrectName(names[i]))
                        {
                            names.Insert(i, names[i]);
                            i++;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}