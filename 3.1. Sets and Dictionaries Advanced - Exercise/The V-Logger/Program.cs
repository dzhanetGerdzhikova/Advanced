using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vlogers = new Dictionary<string, Dictionary<string, System.Collections.Generic.HashSet<string>>>();
            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] splitedInput = input.Split(' ');
                string command = splitedInput[1];

                if (command == "joined")
                {
                    string user = splitedInput[0];
                    if (!vlogers.ContainsKey(user))
                    {
                        vlogers.Add(user, new Dictionary<string, HashSet<string>>());
                        vlogers[user].Add("followed", new HashSet<string>());
                        vlogers[user].Add("following", new HashSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    //Saffrona followed EmilConrad
                    string posledval = splitedInput[0];
                    string posledvan = splitedInput[2];

                    if (posledvan != posledval && vlogers.ContainsKey(posledval) && vlogers.ContainsKey(posledvan))
                    {
                        vlogers[posledvan]["followed"].Add(posledval);
                        vlogers[posledval]["following"].Add(posledvan);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
            var topVloggersSorted = vlogers.OrderByDescending(e => e.Value["followed"].Count)
                                           .ThenBy(e => e.Value["following"].Count)
                                           .ToDictionary(e => e.Key, x => x.Value);
            int counter = 1;
            foreach (var vloger in topVloggersSorted)
            {
                //1. VenomTheDoctor : 2 followers, 0 following
                var followingCount = vloger.Value["following"].Count;
                var followedCount = vloger.Value["followed"].Count;

                Console.WriteLine($"{counter}. {vloger.Key} : {followedCount} followers, {followingCount} following");
                if (counter == 1)
                {
                    foreach (var follower in topVloggersSorted[vloger.Key]["followed"].OrderBy(e => e))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                counter++;
            }
        }
    }
}