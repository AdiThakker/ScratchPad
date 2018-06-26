using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Core
{
    public class Queue<T> where T : IComparable
    {
        private DoubleLinkList<T> linkList;

        public Queue()
        {
            linkList = new DoubleLinkList<T>(); 
        }

        public void Enqueue(T value)
        {
            linkList.AddLast(value);
        }

        public T Dequeue()
        {
            if (linkList.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            return linkList.RemoveFirst();
        }

        public int Count()
        {
            return linkList.Count;
        }
    }
}
