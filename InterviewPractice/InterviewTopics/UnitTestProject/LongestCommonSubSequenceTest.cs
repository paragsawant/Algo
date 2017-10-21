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
    public class LongestCommonSubSequenceTest
    {
        [TestMethod]
        public void LongestCommonSubSequenceTestSucess()
        {
            LongestCommonSubsequence _longestCommonSubSequence = new LongestCommonSubsequence();
            var result = _longestCommonSubSequence.LCS("CATDOGCAT", "DOG");
            Assert.AreEqual(result, 3);
        }
    }
}
