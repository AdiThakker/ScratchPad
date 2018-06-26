using System;

namespace DataStructures.Core
{
    public class LinkListNode<T> where T : IComparable
    {
        public T Value;
        public LinkListNode<T> Next;
    }

    public class LinkList<T> where T : IComparable
    {
        public LinkListNode<T> Head;
        public LinkListNode<T> Tail;
        public int Count = 0;

        public void AddFirst(T value)
        {
            LinkListNode<T> node = new LinkListNode<T>() { Value = value };

            // if first
            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            LinkListNode<T> node = new LinkListNode<T>() { Value = value };

            // If first
            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            Count++;
        }

        public T RemoveFirst()
        {
            T value = default(T);

            // If no items throw error
            if (Count == 0)
                throw new InvalidOperationException("No items to remove.");

            value = Head.Value;

            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var current = Head;
                Head = Head.Next;
                current = null;
            }
            Count--;
            return value;
        }

        public T RemoveLast()
        {
            T value = default(T);

            // If no items throw error
            if (Count == 0)
                throw new InvalidOperationException("No items to remove.");

            if (Count == 1)
            {
                value = Tail.Value;
                Head = null;
                Tail = null;
            }
            else
            {
                LinkListNode<T> current = Head;
                LinkListNode<T> previous = null;
                while (current != Tail)
                {
                    previous = current;
                    current = current.Next;
                }
                value = current.Value;
                Tail = previous;
                current = null;
            }
            Count--;
            return value;
        }

        public bool Remove(T item)
        {
            // If no items throw error
            if (Count == 0)
                throw new InvalidOperationException("No items to remove.");

            LinkListNode<T> current = Head;
            LinkListNode<T> previous = null;
            while (current != null)
            {
                if (current.Value.CompareTo(item) == 0)
                {
                    // if First
                    if (previous == null)
                    {
                        RemoveFirst();
                        return true;
                    }

                    // if Last
                    if (current == Tail)
                    {
                        RemoveLast(); // Not efficient...duplicate work
                        return true;
                    }

                    // if in between
                    previous.Next = current.Next;
                    current = null;
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }

            return false;
        }
    }
}
