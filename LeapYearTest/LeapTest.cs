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

        [TestCase(2000)]
        public void IsEven_ShouldReturnTrue_WhenYearIsDivisibleByFour(int number)
        {
            bool isEven = LeapService.IsEven(number);
            Assert.That(isEven, Is.True);
        }
    }
}