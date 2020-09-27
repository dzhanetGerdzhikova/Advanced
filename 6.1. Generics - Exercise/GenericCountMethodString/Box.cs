using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable
    {
        public Box()
        {
            this.Inputs = new List<T>();
        }

        public List<T> Inputs { get; set; }

        public int Comparer(T compareString, List<T> inputs)
        {
            int counter = 0;

            foreach (var element in this.Inputs)
            {
                if (element.CompareTo(compareString) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}