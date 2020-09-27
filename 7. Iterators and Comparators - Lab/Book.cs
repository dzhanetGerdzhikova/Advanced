using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            if (this.Year < other.Year)
            {
                return -1;
            }
            else if (this.Year == other.Year)
            {
                return this.Title.CompareTo(other.Title);
            }
            else
            {
                return 1;
            }
            // 1) Year

            // If year == year 2
            // compare Title
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}