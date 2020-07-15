using NUnit.Framework;
using Parity;

namespace ParityUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(1651561)]
        [TestCase(-2131289413)]
        public void IsEven_ShouldReturnTrue_WhenNumbersIsNotDivisibleByTwo(int number)
        {
            bool isEven = ParityService.IsEven(number);

            Assert.That(isEven, Is.True);
        }

        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(2104)]
        [TestCase(-218648)]
        [TestCase(0)]
        public void IsEven_ShouldReturnFalse_WhenNumbersIsDivisibleByTwo(int number)
        {
            bool isEven = ParityService.IsEven(number);

            Assert.That(isEven, Is.False);
        }

        [Test]
        public void IsOdd_ShouldReturnFalse_WhenNumbersIsNotDivisibleByTwo()
        {
            bool isOdd = ParityService.IsOdd(1);

            Assert.That(isOdd, Is.False);
        }

        [Test]
        public void IsOdd_ShouldReturnTrue_WhenNumbersIsDivisibleByTwo()
        {
            bool isOdd = ParityService.IsOdd(2);

            Assert.That(isOdd, Is.True);
        }
    }
}