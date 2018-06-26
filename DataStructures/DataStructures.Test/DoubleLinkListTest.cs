using DataStructures.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Test
{
    [TestClass]
    public class DoubleLinkListTest
    {
        [TestMethod]
        public void TestAddFirst()
        {
            var linkedList = new DoubleLinkList<int>();
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
            Assert.IsTrue(linkedList.Tail.Previous.Value == 11);
        }

        [TestMethod]
        public void TestAddLast()
        {
            var linkedList = new DoubleLinkList<int>();
            linkedList.AddLast(10);
            Assert.AreEqual(linkedList.Head, linkedList.Tail);
            Assert.IsTrue(linkedList.Count == 1);

            linkedList.AddLast(11);
            Assert.IsTrue(linkedList.Head.Value == 10);
            Assert.IsTrue(linkedList.Tail.Value == 11);
            Assert.IsTrue(linkedList.Count == 2);
            Assert.IsTrue(linkedList.Tail.Previous.Value == 10);
        }

        [TestMethod]
        public void TestRemoveLast()
        {
            var linkedList = new DoubleLinkList<int>();
            linkedList.AddFirst(11);
            linkedList.AddLast(12);
            linkedList.AddFirst(10);

            Assert.IsTrue(linkedList.Head.Value == 10);
            Assert.IsTrue(linkedList.Tail.Value == 12);

            linkedList.RemoveLast();
            Assert.IsTrue(linkedList.Tail.Value == 11);
            Assert.IsTrue(linkedList.Tail.Previous.Value == 10);
        }

        [TestMethod]
        public void TestRemoveFirst()
        {
            var linkedList = new DoubleLinkList<int>();
            linkedList.AddFirst(11);
            linkedList.AddLast(12);
            linkedList.AddFirst(10);

            Assert.IsTrue(linkedList.Head.Value == 10);
            Assert.IsTrue(linkedList.Tail.Value == 12);

            linkedList.RemoveLast();
            Assert.IsTrue(linkedList.Tail.Value == 11);
            Assert.IsTrue(linkedList.Tail.Previous.Value == 10);
        }

        [TestMethod]
        public void TestRemove()
        {
            var linkedList = new DoubleLinkList<int>();
            linkedList.AddFirst(11);
            linkedList.AddLast(12);
            linkedList.AddFirst(10);

            linkedList.Remove(11);
            Assert.IsTrue(linkedList.Count == 2);
            Assert.IsTrue(linkedList.Tail.Previous.Value == 10);

            linkedList.Remove(15);
            Assert.IsTrue(linkedList.Count == 2);

            linkedList.Remove(12);
            Assert.AreEqual(linkedList.Head, linkedList.Tail);
            Assert.IsTrue(linkedList.Tail.Previous == null);
            linkedList.Remove(10);
            Assert.IsTrue(linkedList.Count == 0);
        }
    }
}
