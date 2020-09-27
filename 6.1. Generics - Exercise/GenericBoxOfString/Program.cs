using System;

namespace GenericBoxOfString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                Console.WriteLine(box.ToString());
            }
        }
    }
}