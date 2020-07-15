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

        [TestCase(2000)]
        [TestCase(2004)]
        [TestCase(2008)]
        [TestCase(108)]
        public void ShouldReturnTrue_WhenYearIsDivisibleByFour(int number)
        {
            bool isLeap = LeapService.IsLeap(number);
            Assert.That(isLeap, Is.True);
        }

        [TestCase(2000)]
        public void ShouldReturnTrue_WhenYearIsSecolar(int number)
        {
            bool isSecolar = LeapService.IsSecolar(number);
            Assert.That(isSecolar, Is.True);
        }

        [TestCase(400)]
        [TestCase(1484)]
        [TestCase(980)]
        [TestCase(120)]
        [TestCase(1268)]
        public void ShouldReturnTrue_WhenYearIsInGiulianCalendar(int number)
        {
            bool isGiulian = LeapService.IsGiulian(number);
            Assert.That(isGiulian, Is.True);
        }

        [TestCase(-1978)]
        [TestCase(-5367)]
        [TestCase(-946)]
        [TestCase(-20)]
        [TestCase(-500)]
        public void ShouldReturnTrue_WhenYearIsBeforeZero(int number)
        {
            bool isBeforeZero = LeapService.IsBeforeZero(number);
            Assert.That(isBeforeZero, Is.True);
        }

        [TestCase(0)]
        //[TestCase(500)]
        //[TestCase(-500)]
        public void ShouldReturnTrue_WhenYearIsZero(int number)
        {
            bool isZero = LeapService.IsZero(number);
            Assert.That(isZero, Is.True);
        }
    }
}