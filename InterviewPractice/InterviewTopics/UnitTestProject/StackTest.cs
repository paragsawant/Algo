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
    public class StackTest
    {
        [TestMethod]
        public void TestSearchElement()
        {
            StacksProblem sp = new StacksProblem();
            var result = sp.GetEvaluatedValue("5*5+2+3*5+6");
            Assert.AreEqual(result,48);
            result = sp.GetEvaluatedValue("5*5+2+3*5");
            Assert.AreEqual(result, 42);
        }

    }
}
