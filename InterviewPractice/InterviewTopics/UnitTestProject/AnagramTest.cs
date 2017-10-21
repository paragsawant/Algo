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
    public class AnagramTest
    {
        [TestMethod]
        public void TestAnagramSuccess()
        {
            Anagram _anagram = new Anagram();
            bool result = _anagram.isAnagram("Parag", "agarP");
            Assert.AreEqual(true, result);
            result = _anagram.isAnagram("", "");
            Assert.AreEqual(true, result);
            result = _anagram.isAnagram(null,null);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestAnagramFail()
        {
            Anagram _anagram = new Anagram();
            bool result = _anagram.isAnagram("parag", "agarP");
            Assert.AreEqual(false, result);
            result = _anagram.isAnagram("P", "P1");
            Assert.AreEqual(false, result);
            result = _anagram.isAnagram("P", null);
            Assert.AreEqual(false, result);
        }
    }
}
