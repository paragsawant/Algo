using InterviewTopics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class ArrayProblemTest
    {
        [TestMethod]
        public void TestSearchElement()
        {
            ArrayProblems arr = new ArrayProblems();
            var result = arr.SearchElement1(new int[] { 8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3 }, 3);
            Assert.AreEqual(7, result);

            result = arr.SearchElement1(new int[] { 8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3 }, 2);
            Assert.AreEqual(8, result);

            result = arr.SearchElement2(new int[] { 8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3 }, 2);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMagicIndex()
        {
            ArrayProblems arr = new ArrayProblems();
            var result = arr.MagicIndex(new int[] { -1, 0, 1, 2, 3, 5, 8, 10, 12, 13, 14, 15 });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMagicIndexRec()
        {
            ArrayProblems arr = new ArrayProblems();

            var result = arr.MagicIndexRec(new int[] { 1, 2, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, 0, 11);
            Assert.AreEqual(2, result);
            result = arr.MagicIndexRec(new int[] { 1, 2, 4, 5, 6, 7, 8, 9, 10, 10, 10, 13 }, 0, 11);
            Assert.AreEqual(10, result);
        }
    }
}
