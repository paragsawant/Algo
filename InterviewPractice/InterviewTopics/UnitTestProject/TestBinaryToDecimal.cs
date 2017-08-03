using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewTopics;

namespace UnitTestProject
{
    [TestClass]
    public class TestBinaryToDecimal
    {
        [TestMethod]
        public void TestBinaryToDecimal_ValidInput()
        {

            var result = BinaryToDecimal.Convert("1000");
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "No input")]
        public void TestBinaryToDecimal_NoInput()
        {
            var result = BinaryToDecimal.Convert("");

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Invalid input")]
        public void TestBinaryToDecimal_InvalidInput()
        {
            var result = BinaryToDecimal.Convert("2000");
        }
    }
}
