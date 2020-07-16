using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnZeroForInputString()
        {
            int number = StringCalculatorService.Add("");

            Assert.That(number, Is.EqualTo(0));
        }

        [Test]
        public void ReturnNumberForNumber()
        {
            int number = StringCalculatorService.Add("1");

            Assert.That(number, Is.EqualTo(1));
        }
    }
}