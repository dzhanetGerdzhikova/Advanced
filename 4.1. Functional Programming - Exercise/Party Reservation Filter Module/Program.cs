using System;
using System.Collections.Generic;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Filter> filters = new List<Filter>();

            string input = Console.ReadLine();
            string secondPart = "";
            string info = "";

            while (input != "Print")
            {
                string[] splitedInput = input.Split(';');
                string firstPart = splitedInput[0];
                secondPart = splitedInput[1];
                info = splitedInput[2];

                if (firstPart == "Add filter")
                {
                    filters.Add(new Filter(secondPart, info));
                }
                else if (firstPart == "Remove filter")
                {
                    filters.RemoveAll(x => x.FilterTypes == secondPart && x.FilterParameter == info);
                }

                input = Console.ReadLine();
            }
            foreach (var item in filters)
            {
                Predicate<string> isNameCorrect = x => secondPart switch
                {
                    "Starts with" => x.StartsWith(item.FilterParameter),
                    "Ends with" => x.EndsWith(item.FilterParameter),
                    "Length" => x.Length == int.Parse(item.FilterParameter),
                    "Contains" => x.Contains(item.FilterParameter),
                };
                names.RemoveAll(isNameCorrect);
            }
            if (names.Any())
            {
                Console.WriteLine(string.Join(" ", names));
            }
        }
    }

    internal class Filter
    {
        public Filter(string filterTypes, string filterParameter)
        {
            FilterTypes = filterTypes;
            FilterParameter = filterParameter;
        }

        public string FilterTypes { get; set; }
        public string FilterParameter { get; set; }
    }
}