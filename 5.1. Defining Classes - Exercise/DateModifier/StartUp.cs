using MyHelpLibrary;
using System;

namespace DateModifierSpace
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            DateModifier.DifferenceOfDays(firstDate, secondDate);
            Console.WriteLine(DateModifier.DifferenceInDates);
        }
    }
}