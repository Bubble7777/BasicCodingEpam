using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace BasicCodingTest
{
    [TestClass()]
    public class FilterDigitTest
    {
        [TestMethod()]
        public void FilterDigitTestMethod()
        {
            List<int> expected = new List<int>(){ 7, 7, 70, 17 };
            int[] array = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            List<int> actual = BasicCoding.BasicCoding.FilterDigit(array, 7);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}