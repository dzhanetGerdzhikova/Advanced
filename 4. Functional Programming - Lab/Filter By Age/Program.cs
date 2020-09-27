using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_By_Age
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());

            Dictionary<string, int> peopleInfo = new Dictionary<string, int>();

            for (int i = 0; i < countLines; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int ageOfPerson = int.Parse(input[1]);

                peopleInfo[name] = ageOfPerson;
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<KeyValuePair<string, int>, bool> filterFunction = condition switch
            {
                "younger" => x => x.Value < age,
                "older" => x => x.Value >= age,
                _ => throw new NotImplementedException()
            };

            Func<KeyValuePair<string, int>, string> selectFunction = format switch
            {
                "name age" => x => $"{x.Key} - {x.Value}",
                "name" => x => $"{x.Key}",
                "age" => x => $"{x.Value}",
                _ => throw new NotImplementedException()
            };

            peopleInfo.Where(filterFunction).Select(selectFunction).ToList().ForEach(Console.WriteLine);
        }
    }
}