using System;

namespace GenericCountMethodDouble
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            Box<double> obekt = new Box<double>();

            for (int i = 0; i < countLines; i++)
            {
                double input = double.Parse(Console.ReadLine());
                obekt.SavedInputs.Add(input);
            }

            double comparableNum = double.Parse(Console.ReadLine());
            int count = obekt.Comparable(comparableNum, obekt.SavedInputs);
            Console.WriteLine(count);
        }
    }
}