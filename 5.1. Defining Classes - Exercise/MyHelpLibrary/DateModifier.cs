using System;

namespace MyHelpLibrary
{
    public static class DateModifier
    {
        public static int DifferenceInDates { get; set; }

        public static int DifferenceOfDays(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);

            TimeSpan difference = startDate - endDate;
            DifferenceInDates = (int)Math.Abs(difference.TotalDays);
            return DifferenceInDates;
        }
    }
}