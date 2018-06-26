using DataStructures.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataStructures.Test
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void TestQueueActions()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(12);
            Assert.IsTrue(queue.Count() == 2);
            Assert.IsTrue(queue.Dequeue() == 10);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestQueueActionsthrowException()
        {
            Queue<int> queue = new Queue<int>();
            Assert.IsTrue(queue.Dequeue() == 10);
        }
    }
}
