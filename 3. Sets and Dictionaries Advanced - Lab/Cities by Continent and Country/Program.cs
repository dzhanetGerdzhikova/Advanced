using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < countLines; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continentTemp = input[0];
                string countryTemp = input[1];
                string cityTemp = input[2];

                if (!continents.ContainsKey(continentTemp))
                {
                    continents[continentTemp] = new Dictionary<string, List<string>>();
                }

                if (!continents[continentTemp].ContainsKey(countryTemp))
                {
                    continents[continentTemp][countryTemp] = new List<string>();
                }

                continents[continentTemp][countryTemp].Add(cityTemp);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}