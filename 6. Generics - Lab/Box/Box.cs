﻿using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> box;
        public int Count => box.Count;

        public Box()
        {
            box = new Stack<T>();
        }

        public void Add(T element)
        {
            box.Push(element);
        }

        public T Remove()
        {
            return box.Pop();
        }
    }
}