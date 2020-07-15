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

        #region - Uncomment this to see errors -
        //[TestCase(1400)]
        //[TestCase(100)]
        //[TestCase(2000)]
        //[TestCase(2006)]
        //[TestCase(2002)]
        #endregion

        [TestCase(400)]
        [TestCase(2004)]
        [TestCase(2008)]
        [TestCase(108)]
        public void ShouldReturnTrue_WhenYearIsDivisibleByFour(int number)
        {
            bool isEven = LeapService.IsEven(number);
            Assert.That(isEven, Is.True);
        }
    }
}