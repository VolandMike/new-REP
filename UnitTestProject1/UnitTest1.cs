using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
 

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            FirstSteps firstSteps = new FirstSteps();
            int k = firstSteps.sum(1, 2);
            Assert.AreEqual(k, 3);
        }
        [TestMethod]
        public void TestMul()
        {
            FirstSteps fs = new FirstSteps();
            int k = fs.mul(1, 3);
            Assert.AreEqual(3, k);

        }
        [TestMethod]
        public void TestDiv()
        {
            FirstSteps fs = new FirstSteps();
            int k = fs.div(15, 3);
            Assert.AreEqual(5, k);
        }
    }
}
