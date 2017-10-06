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
    public class NumberTest
    {
        [TestMethod]
        public void Deciaml2BinaryTest()
        {
            NumbersQuestions NQ = new NumbersQuestions();
            var value = NQ.Deciaml2Binary(4);
        }

    }
}
