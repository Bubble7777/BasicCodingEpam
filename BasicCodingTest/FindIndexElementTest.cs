using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BasicCodingTest
{
    [TestClass]
    public class FindIndexElementTest
    {
        [TestMethod]
        public void FindIndexElement_Test1()
        {
            int expected = 4;
            double[] array = { 5.0, 5.0, 2.0, 1.0, 30.0, 5.0, 4.0, 3.0, 1.0 };
            double actual = BasicCoding.BasicCoding.FindIndex(array);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(new double[] { 0.3, 0.9, 1.5, 0.6, 0.6 }, 2)]
        [DataRow(new double[] { 35.555, 0.9, 1.5, 0.6, 0.6, 2.349, 30.506 }, 1)]
        public void FindIndexForMiddlePositionTest(double[] array, int expected)
        {
            double actual = BasicCoding.BasicCoding.FindIndex(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
