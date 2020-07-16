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
        public void ReturnZero_WhenInputIsAnEmptyString()
        {
            int number = StringCalculatorService.Add("");

            Assert.That(number, Is.EqualTo(0));
        }

        [Test]
        public void ReturnANumber_WhenInputIsANumber()
        {
            int number = StringCalculatorService.Add("1");

            Assert.That(number, Is.EqualTo(1));
        }

        [Test]
        public void ReturnTheSum_WhenInputAreTwoNumbers()
        {
            int numbers = StringCalculatorService.Add("1, 2");

            Assert.That(numbers, Is.EqualTo(3));
        }

        [Test]
        public void ReturnTheSum_WhenInputIsAListOfNumbers()
        {
            int numbers = StringCalculatorService.Add("1, 2, 3, 5, 10");

            Assert.That(numbers, Is.EqualTo(21));
        }

        //[Test]
        public void ReturnTheSum_WhenSeparatorsAreDifferent()
        {
            int numbers = StringCalculatorService.Add("1/n2, 3, 5/n10");

            Assert.That(numbers, Is.EqualTo(21));
        }
    }
}