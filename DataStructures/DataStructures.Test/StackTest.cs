using DataStructures.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataStructures.Test
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void TestStackActions()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(15);
            Assert.IsTrue(stack.Count() == 1);
            stack.Push(10);
            stack.Push(11);
            Assert.IsTrue(stack.Pop() == 11);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestStackActionThrowsException()
        {
            Stack<int> stack = new Stack<int>();
            Assert.IsTrue(stack.Pop() == 10);
        }
    }
}
