using Awesome_Automated_Test.Fundamentals;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GetOutput_InputIsDivisibleBy3_ReturnsFizz(int number)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void GetOutput_InputIsDivisibleBy5_ReturnsBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        [TestCase(0)]
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(60)]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnsFizzBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(16)]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnsNumber(int number)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo(number.ToString()));
        }
    }
}