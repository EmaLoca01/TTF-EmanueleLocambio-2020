using NUnit.Framework;
using LeapYear;

namespace LeapYearTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[TestCase(2006)]
        //[TestCase(2002)]
        [TestCase(2004)]
        [TestCase(2000)]
        [TestCase(2008)]
        [TestCase(100)]
        [TestCase(108)]
        [TestCase(1400)]
        public void IsEven_ShouldReturnTrue_WhenYearIsDivisibleByFour(int number)
        {
            bool isEven = LeapService.IsEven(number);
            Assert.That(isEven, Is.True);
        }
    }
}