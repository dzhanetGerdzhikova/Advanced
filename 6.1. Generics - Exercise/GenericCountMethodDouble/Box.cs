using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable
    {
        public Box()
        {
            this.SavedInputs = new List<T>();
        }

        public List<T> SavedInputs { get; set; }

        public int Comparable(T comparableElement, List<T> inputs)
        {
            int count = 0;
            foreach (var element in inputs)
            {
                if (element.CompareTo(comparableElement) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var element in this.SavedInputs)
            {
                result.AppendLine(element.ToString());
            }
            return result.ToString();
        }
    }
}