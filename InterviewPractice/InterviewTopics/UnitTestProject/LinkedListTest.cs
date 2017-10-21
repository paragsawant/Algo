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
    public class LinkedListTest
    {
        [TestMethod]
        public void LinkedListOperationTest()
        {
            LinkedList lkl = new LinkedList();
            lkl.Add(10);
            lkl.Add(20);
            lkl.Add(30);
            lkl.Add(40);
            var result = lkl.PrintLinkedList(lkl.head);
            lkl.Reverse(lkl.head);
        }
    }
}
