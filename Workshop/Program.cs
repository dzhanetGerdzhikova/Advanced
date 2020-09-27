using System;
using System.Collections.Generic;

namespace Workshop1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list.InsertAt(1, 30);
            List<int> str = new List<int>();
            str.Add(3);
            
            
            
            MyStack stack = new MyStack();
            stack.Push(1000);
            stack.Push(200);
            stack.Push(50);
            int result = stack.Pop();
            Console.WriteLine();
        }
    }
}
