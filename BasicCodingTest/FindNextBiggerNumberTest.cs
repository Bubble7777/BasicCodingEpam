using NUnit.Framework;

namespace BasicCodingTest
{
    class FindNextBiggerNumberTest
    {
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1243321)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3465432)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]

        public int FindNextBiggerTestMethod(int number)
        {
            return BasicCoding.BasicCoding.FindNextBiggerNumber(number);
        }
    }
}
