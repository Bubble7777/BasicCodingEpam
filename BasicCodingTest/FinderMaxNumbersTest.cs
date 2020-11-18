using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicCodingTest
{
    [TestClass]
    public class FinderMaxNumbersTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FinderMaxNumber_NullException()
        {
            int[] a = null;
            int actual = BasicCoding.BasicCoding.FindMaxNumber(a);
        }

        [TestMethod]
        public void FinderMaxNumber_Test1()
        {
            int expected = 101;
            int[] array = { 1, 4, 5, 6, 12, 35, -2, 101 };
            int actual = BasicCoding.BasicCoding.FindMaxNumber(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FinderMaxNumber_Test2()
        {
            int expected = -55;
            int[] array = { -121, -64, -55, -66, -120, -355, -220, -101 };
            int actual = BasicCoding.BasicCoding.FindMaxNumber(array, 0);
            Assert.AreEqual(expected, actual);
        }
    }
}
