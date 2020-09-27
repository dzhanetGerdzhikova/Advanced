using System;

namespace GenericCountMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();
                box.Inputs.Add(input);
            }

            string compareElelment = Console.ReadLine();
            int count = box.Comparer(compareElelment, box.Inputs);
            Console.WriteLine(count);
        }
    }
}