using InterviewTopics;
using LongestCommonSubstring;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class RandomTest
    {
        [TestMethod]
        public void test()
        {
            var returnValue =LongestCommonSubString.lcs("abab", "baba");
            returnValue = LongestCommonSubString.lcs("sneha", "shape");
            ReverseWords rev = new ReverseWords();
            rev.Reverse("My Name is :  Sweta");
        }
    }
}
