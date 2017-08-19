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
    public class BinarySearchProblemTest
    {
        [TestMethod]
        public void TestBinaySearch()
        {
            BinarySearchProblem bs = new BinarySearchProblem();
            var poistion = bs.BinarySearch(45, new int[] { 1, 2, 3, 4, 5, 7, 25, 40, 45, 55 });
            Assert.AreEqual(poistion, 8);
        }

        [TestMethod]
        public void TestSearchToFindUnique()
        {
            BinarySearchProblem bs = new BinarySearchProblem();
            var poistion = bs.SearchToFindUnique(new int[] { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8 });
            Assert.AreEqual(poistion, 8);
        }
    }
}
