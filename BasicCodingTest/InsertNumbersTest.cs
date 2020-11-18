using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BasicCodingTest
{
    [TestClass]
    public class InsertNumbersTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumber_ArgumentException_I_More_J()
        {
            BasicCoding.BasicCoding.InsertNumber(12, 12, 25, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumber_ArgumentException_overflow()
        {
            BasicCoding.BasicCoding.InsertNumber(12, 13, 15, 31);
            BasicCoding.BasicCoding.InsertNumber(12, 13, 15, 32);
            BasicCoding.BasicCoding.InsertNumber(12, 13, 31, 15);
            BasicCoding.BasicCoding.InsertNumber(12, 13, 32, 15);
            BasicCoding.BasicCoding.InsertNumber(12, 13, -1, 15);
            BasicCoding.BasicCoding.InsertNumber(12, 13, 15, -1);
        }

        [TestMethod]
        public void Insert_Test_Method1()
        {
            int expected = 15;
            int actual = BasicCoding.BasicCoding.InsertNumber(15, 15, 0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Insert_Test_Method2()
        {
            int expected = 9;
            int actual = BasicCoding.BasicCoding.InsertNumber(8, 15, 0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Insert_Test_Method3()
        {
            int expected = 120;
            int actual = BasicCoding.BasicCoding.InsertNumber(8, 15, 3, 8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindIndexElement_Test1()
        {
            int expected = 4;
            double[] array = { 5.0, 5.0, 2.0, 1.0, 30.0, 5.0, 4.0, 3.0, 1.0 };
            double actual = BasicCoding.BasicCoding.FindIndex(array);
            Assert.AreEqual(expected, actual);
        }

    }
}
