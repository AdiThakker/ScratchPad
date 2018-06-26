using DataStructures.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Test
{
    [TestClass]
    public class StringsTest
    {
        [TestMethod]
        public void TestParsedList()
        {
            Strings strings = new Strings();
            Assert.IsTrue(strings.GetStringsBetween().SequenceEqual(new List<string> { "string 1", "string 2", "string 3" }));
        }

        [TestMethod]
        public void TestStringReverse()
        {
            Assert.AreEqual(new Strings().Reverse("Hello World!"), "!dlroW olleH");
        }
    }
}
