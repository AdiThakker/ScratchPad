using DataStructures.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataStructures.Test
{
    [TestClass]
    public class LinkListTest
    {
        [TestMethod]
        public void TestAddFirst()
        {
            var linkedList = new LinkList<int>();
            linkedList.AddFirst(10);
            Assert.AreEqual(linkedList.Head, linkedList.Tail);
            Assert.IsTrue(linkedList.Count == 1);

            linkedList.AddFirst(11);
            Assert.IsTrue(linkedList.Head.Value == 11);
            Assert.IsTrue(linkedList.Tail.Value == 10);
            Assert.IsTrue(linkedList.Count == 2);

            linkedList.AddFirst(12);
            Assert.IsTrue(linkedList.Head.Value == 12);
            Assert.IsTrue(linkedList.Tail.Value == 10);
            Assert.IsTrue(linkedList.Count == 3);
        }

        [TestMethod]
        public void TestAddLast()
        {
            var linkedList = new LinkList<int>();
            linkedList.AddLast(10);
            Assert.AreEqual(linkedList.Head, linkedList.Tail);
            Assert.IsTrue(linkedList.Count == 1);

            linkedList.AddLast(11);
            Assert.IsTrue(linkedList.Head.Value == 10);
            Assert.IsTrue(linkedList.Tail.Value == 11);
            Assert.IsTrue(linkedList.Count == 2);
        }

        [TestMethod]
        public void TestRemoveLast()
        {
            var linkedList = new LinkList<int>();
            linkedList.AddFirst(11);
            linkedList.AddLast(12);
            linkedList.AddFirst(10);

            Assert.IsTrue(linkedList.Head.Value == 10);
            Assert.IsTrue(linkedList.Tail.Value == 12);

            linkedList.RemoveLast();
            Assert.IsTrue(linkedList.Tail.Value == 11);

        }

        [TestMethod]
        public void TestRemoveFirst()
        {
            var linkedList = new LinkList<int>();
            linkedList.AddFirst(11);
            linkedList.AddLast(12);
            linkedList.AddFirst(10);

            Assert.IsTrue(linkedList.Head.Value == 10);
            Assert.IsTrue(linkedList.Tail.Value == 12);

            linkedList.RemoveLast();
            Assert.IsTrue(linkedList.Tail.Value == 11);

        }

        [TestMethod]
        public void TestRemove()
        {
            var linkedList = new LinkList<int>();
            linkedList.AddFirst(11);
            linkedList.AddLast(12);
            linkedList.AddFirst(10);

            linkedList.Remove(11);
            Assert.IsTrue(linkedList.Count == 2);

            linkedList.Remove(15);
            Assert.IsTrue(linkedList.Count == 2);

            linkedList.Remove(12);
            Assert.AreEqual(linkedList.Head, linkedList.Tail);
            linkedList.Remove(10);
            Assert.IsTrue(linkedList.Count == 0);
        }

        [TestMethod]
        public void TestGetNthItem()
        {
            var linkedList = new LinkList<int>();
            for (int i = 11; i <= 20; i++)
            {
                linkedList.AddLast(i);
            }

            Assert.IsTrue(linkedList.Count == 10);

            var item = FindNthFromtheLast(linkedList.Head);
            Assert.IsTrue(item == 10);

            int count = 1;
            var runner = linkedList.Head;
            while (count <= 5)
            {
                runner = runner.Next;
                count++;
            }

            var current = linkedList.Head;
            while (runner != null)
            {
                current = current.Next;
                runner = runner.Next;
            }
            Assert.IsTrue(current.Value == 16);
        }

        private int FindNthFromtheLast(LinkListNode<int> node)
        {
            if (node == null)
                return 0;

            int nthItem = FindNthFromtheLast(node.Next) + 1;
            if (nthItem == 5)
            {
                Console.WriteLine($"{node.Value} is the 5th.");
            }

            return nthItem;
        }
    }
}
