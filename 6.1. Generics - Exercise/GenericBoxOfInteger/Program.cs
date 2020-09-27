using System;

namespace GenericBoxOfInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(numbers);
                Console.WriteLine(box.ToString());
            }
        }
    }
}