using DataStructures.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DataStructures.Test
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestBubbleSortThrowsException()
        {
            int[] array = new int[] { };
            new Sort().BubbleSortArray(array);
        }
        [TestMethod]
        public void TestBubbleSort()
        {
            int[] array = new int[] { 5, 3, 2, 6, 7, 1, 8, 4, 5, 10 };
            new Sort().BubbleSortArray(array);
            Assert.IsTrue(array.SequenceEqual(new int[] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 10 }));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInsertionSortThrowsException()
        {
            int[] array = new int[] { };
            new Sort().InsertionSortArray(array);
        }

        [TestMethod]
        public void TestInsertionSort()
        {
            int[] array = new int[] { 5, 3, 2, 6, 7, 1, 8, 4, 5, 10 };
            new Sort().InsertionSortArray(array);
            Assert.IsTrue(array.SequenceEqual(new int[] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 10 }));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMergeSortThrowsException()
        {
            int[] array = new int[] { };
            new Sort().MergeSortArray(array);
        }

        [TestMethod]
        public void TestMergeSort()
        {
            int[] array = new int[] { 5, 3, 2, 6, 7, 1, 8, 4, 5, 10, 11, 2 };
            new Sort().MergeSortArray(array);
            Assert.IsTrue(array.SequenceEqual(new int[] { 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 10, 11 }));
        }

    }
}
