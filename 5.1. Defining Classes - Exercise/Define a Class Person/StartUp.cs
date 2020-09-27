using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Person person1 = new Person();
            //person1.Name = "Pesho";
            //person1.Age = 20;

            //Person person2 = new Person()
            //{
            //    Name = "Gosho",
            //    Age = 18
            //};

            //Person person3 = new Person()
            //{
            //    Name = "Stamat",
            //    Age = 43
            //};

            //Person person1 = new Person();
            //Person person2 = new Person(10);
            //Person person3 = new Person("Ivan", 30);

            int countLines = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < countLines; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);

                family.AddMember(new Person(name, age));
            }

            //Person oldest = family.GetOldestMember();
            //Console.WriteLine($"{oldest.Name} {oldest.Age}");

            foreach (var person in family.SortAgeMoreThan30())
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}