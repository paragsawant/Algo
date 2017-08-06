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
    public class BinarySearchTest
    {
        [TestMethod]
        public void TestBinaySearch()
        {
            BinarySearchProblem bs = new BinarySearchProblem();
            var poistion = bs.BinarySearch(45, new int[] { 1, 2, 3, 4, 5, 7, 25, 40, 45, 55 });
            Assert.AreEqual(poistion, 8);
        }
    }
}
