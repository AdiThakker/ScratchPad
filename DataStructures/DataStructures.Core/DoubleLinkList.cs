using System;

namespace DataStructures.Core
{
    public class DoubleLinkListNode<T> : LinkListNode<T> where T : IComparable
    {
        public DoubleLinkListNode<T> Previous;
    }

    public class DoubleLinkList<T> where T : IComparable
    {
        public DoubleLinkListNode<T> Head;
        public DoubleLinkListNode<T> Tail;
        public int Count = 0;

        public void AddFirst(T value)
        {
            DoubleLinkListNode<T> node = new DoubleLinkListNode<T>() { Value = value };

            // if first
            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            DoubleLinkListNode<T> node = new DoubleLinkListNode<T>() { Value = value };

            // If first
            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
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
                Head = (DoubleLinkListNode<T>)Head.Next;
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
                value = Tail.Value;
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            Count--;
            return value;
        }

        public bool Remove(T item)
        {
            // If no items throw error
            if (Count == 0)
                throw new InvalidOperationException("No items to remove.");

            DoubleLinkListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.CompareTo(item) == 0)
                {
                    // if First
                    if (current.Previous == null)
                    {
                        RemoveFirst();
                        return true;
                    }

                    // if Last
                    if (current == Tail)
                    {
                        RemoveLast(); 
                        return true;
                    }

                    // if in between
                    current.Previous.Next = current.Next;
                    ((DoubleLinkListNode<T>)current.Next).Previous = current.Previous;
                    current = null;
                    Count--;
                    return true;
                }
                current = (DoubleLinkListNode<T>)current.Next;
            }

            return false;
        }
    }
}
