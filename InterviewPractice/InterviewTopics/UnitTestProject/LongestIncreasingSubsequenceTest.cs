using InterviewTopics.DP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class LongestIncreasingSubsequenceTest
    {
        [TestMethod]
        public void LISTest()
        {
            LongestIncreasingSubsequence _lis = new LongestIncreasingSubsequence();
            int[] arr = new int[] { 10, 22, 9, 33, 21, 50, 41, 60 };
            int value = _lis.LIS(arr);
            Assert.AreEqual(5, value);
        }
    }
}
