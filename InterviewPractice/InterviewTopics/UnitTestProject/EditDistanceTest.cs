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
    public class EditDistanceTest
    {
        [TestMethod]
        public void EditDistanceTestSucess()
        {
            EditDistance _editDistance = new EditDistance();
            var result = _editDistance.ED("CAT", "DOG", 3, 3);
            Assert.AreEqual(result, 3);
            result = _editDistance.ED("CAT", "BAT", 3, 3);
            Assert.AreEqual(result, 1);

            result = _editDistance.ED("sunday", "saturday", 6, 8);
            Assert.AreEqual(result, 3);
        }
    }
}
