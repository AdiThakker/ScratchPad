using DataStructures.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Test
{
    [TestClass]
    public class NumericTest
    {
        [TestMethod]
        public void TestIsPrime()
        {
            Numeric numeric = new Numeric();
            Assert.IsFalse(numeric.IsPrime(1));
            Assert.IsFalse(numeric.IsPrime(6));
            Assert.IsTrue(numeric.IsPrime(39));
            Assert.IsTrue(numeric.IsPrime(41));
        }

        [TestMethod]
        public void TestPrimes()
        {
            Numeric numeric = new Numeric();
            var result = numeric.GetPrimes(12).ToList();
            Assert.IsTrue(result.SequenceEqual(new List<int>() { 2, 3, 5, 7, 11 }));
        }

        [TestMethod]
        public void TestGCD()
        {
            Numeric numeric = new  Numeric();
            Assert.IsTrue(numeric.GetGCD(85, 34) == 17);
        }

        [TestMethod]
        public void TestGCDRecursive()
        {
            Numeric numeric = new  Numeric();
            Assert.IsTrue(numeric.GetGCDRecursive(85, 34) == 17);
        }
    }
}
