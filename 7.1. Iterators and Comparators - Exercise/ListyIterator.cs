using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListyIteratort
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> inputs;
        private int index;

        public ListyIterator(List<T> input)
        {
            this.index = 0;
            this.inputs = input;
        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            if (index + 1 < inputs.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (!this.inputs.Any())
            {
                throw new InvalidOperationException("Invalid operation!");
            }
            Console.WriteLine(this.inputs[this.index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var el in this.inputs)
            {
                yield return el;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}