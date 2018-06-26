using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Core
{
    public class Stack<T> where T : IComparable
    {
        private DoubleLinkList<T> linkList;

        public Stack()
        {
            linkList = new DoubleLinkList<T>();
        }

        public void Push(T value)
        {
            linkList.AddFirst(value);
        }

        public T Pop()
        {
            if (linkList.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            return linkList.RemoveFirst();
        }

        public int Count()
        {
            return linkList.Count;
        }
    }
}
