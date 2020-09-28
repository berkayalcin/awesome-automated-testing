using System.Linq;
using Awesome_Automated_Test.Fundamentals;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;


        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }


        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(2, 5, 7)]
        [TestCase(8, 5, 13)]
        public void Add_WhenCalled_ReturnTheSumOfArguments(int a, int b, int expectedResult)
        {
            var result = _math.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(2, 3, 3)]
        [TestCase(2, 1, 2)]
        [TestCase(3, 3, 3)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(5)]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnsOddNumbersUpToLimit(int limit)
        {
            var result = _math.GetOddNumbers(limit);


            Assert.That(result, Is.EquivalentTo(new[] {1, 3, 5}));
        }
    }
}