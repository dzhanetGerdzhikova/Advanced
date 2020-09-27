using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsGrade = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < countStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentsGrade.ContainsKey(name))
                {
                    studentsGrade.Add(name, new List<decimal>());
                }
                studentsGrade[name].Add(grade);
            }

            foreach (var name in studentsGrade)
            {
                Console.WriteLine($"{name.Key} -> {string.Join(' ', name.Value.Select(x => x.ToString("F2")))} (avg: {name.Value.Average():F2})");
            }
        }
    }
}