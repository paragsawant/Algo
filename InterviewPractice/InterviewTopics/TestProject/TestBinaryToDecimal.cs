using InterviewTopics;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject
{
    public class TestBinaryToDecimal
    {
        [Fact]
        public void TestBinaryToDecimal_Sucess()
        {
            var result = BinaryToDecimal.Convert("1000");
            Assert.Equal(16, result);
        }
    }
}
