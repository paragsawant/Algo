using InterviewTopics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void TestStringPalindromeSuccess()
        {
            Palindrome _palindrome = new Palindrome();
            bool result = _palindrome.isPalindrome("ABBA");
            Assert.AreEqual(result, true);
            result = _palindrome.isPalindrome("ABDBA");
            Assert.AreEqual(result, true);
            result = _palindrome.isPalindrome("ABDDBA");
            Assert.AreEqual(result, true);
            result = _palindrome.isPalindrome("");
            Assert.AreEqual(result, true);
            result = _palindrome.isPalindrome("P");
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestStringPalindromeFail()
        {
            Palindrome _palindrome = new Palindrome();
            bool result = _palindrome.isPalindrome("ABDAPDBA");
            Assert.AreEqual(result, false);
            result = _palindrome.isPalindrome("ABDABA");
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void TestIntPalindromeSuccess()
        {
            Palindrome _palindrome = new Palindrome();
            bool result = _palindrome.isPalindrome(12121);
            Assert.AreEqual(result, true);
            result = _palindrome.isPalindrome(1221);
            Assert.AreEqual(result, true);
            result = _palindrome.isPalindrome(11);
            Assert.AreEqual(result, true);
            result = _palindrome.isPalindrome(222);
            Assert.AreEqual(result, true);
            result = _palindrome.isPalindrome(1);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestIntPalindromeFail()
        {
            Palindrome _palindrome = new Palindrome();
            bool result = _palindrome.isPalindrome(121251);
            Assert.AreEqual(result, false);
            result = _palindrome.isPalindrome(124521);
            Assert.AreEqual(result, false);
            result = _palindrome.isPalindrome(21);
            Assert.AreEqual(result, false);
            result = _palindrome.isPalindrome(2382);
            Assert.AreEqual(result, false);
            result = _palindrome.isPalindrome(12222222);
            Assert.AreEqual(result, false);
        }
    }
}
