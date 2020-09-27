using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //"end of contests"

            string input = Console.ReadLine();
            Dictionary<string, string> contestsWithPasswords = new Dictionary<string, string>();

            while (input != "end of contests")
            {
                string[] splitedInput = input.Split(':');
                string contest = splitedInput[0];
                string password = splitedInput[1];

                if (!contestsWithPasswords.ContainsKey(contest))
                {
                    contestsWithPasswords.Add(contest, password);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            //"{contest}=>{password}=>{username}=>{points}"
            Dictionary<string, Dictionary<string, int>> studentsWithContests = new Dictionary<string, Dictionary<string, int>>();

            while (input != "end of submissions")
            {
                string[] splitedInput = input.Split("=>");
                string contest = splitedInput[0];
                string password = splitedInput[1];
                string user = splitedInput[2];
                int points = int.Parse(splitedInput[3]);

                if (!contestsWithPasswords.ContainsKey(contest))
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (contestsWithPasswords[contest] != password)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (!studentsWithContests.ContainsKey(user))
                {
                    studentsWithContests.Add(user, new Dictionary<string, int>());
                }
                if (!studentsWithContests[user].ContainsKey(contest))
                {
                    studentsWithContests[user].Add(contest, points);
                }
                if (studentsWithContests[user][contest] < points)
                {
                    studentsWithContests[user][contest] = points;
                }
                input = Console.ReadLine();
            }

            var topCandidate = studentsWithContests.OrderByDescending(x => x.Value.Sum(y => y.Value)).FirstOrDefault();

            Console.WriteLine($"Best candidate is {topCandidate.Key} with total {topCandidate.Value.Sum(x => x.Value)} points.");
            Console.WriteLine("Ranking:");

            foreach (var studentName in studentsWithContests.OrderBy(e => e.Key))
            {
                Console.WriteLine(studentName.Key);
                foreach (var (contest, points) in studentName.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }
        }
    }
}