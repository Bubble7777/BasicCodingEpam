using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicCodingTest
{
    [TestClass()]
    public class ConcateLatinAlphabetTest
    {
        [TestMethod()]
        public void ConcateAlphabetTest()
        {
            string firstWord = "Hello";
            string secondWorld = "HelloWorld";
            Assert.AreEqual(BasicCoding.BasicCoding.ConcateLatinAlphabet(firstWord, secondWorld), "HeloWrd");
        }
    }
}