using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop1
{
    public class MyStack
    {
        private int[] Items { get; set; }
        public int Count { get; private set; }
        private const int Capacity = 4;
        public MyStack()
        {
            this.Items = new int[Capacity];
            this.Count = 0;
        }
        public void Resize()
        {
            int[] newArray = new int[this.Items.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = this.Items[i];
            }
            this.Items = newArray;

        }
        public void Push(int num)
        {
            if (this.Count == this.Items.Length)
            {
                Resize();
            }
            this.Items[this.Count] = num;
            this.Count++;
        }
        public int Pop()
        {
            if(this.Items.Length==0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            this.Count--;
            this.Items[Count - 1] = default;
            return this.Items[Count - 1];
        }
        public int Peek()
        {
            if (this.Items.Length == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return this.Items[Count - 1];
        }
        public void Foreach(Action<object>action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.Items[i]);
            }
        }
    }
}
