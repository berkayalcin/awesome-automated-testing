using System;
using Awesome_Automated_Test.Fundamentals;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }

        [TearDown]
        public void TearDown()
        {
        }


        [Test]
        [TestCase(391)]
        [TestCase(301)]
        [TestCase(-1)]
        [TestCase(-10)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowsArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => _calculator.CalculateDemeritPoints(speed), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(10, 0)]
        [TestCase(20, 0)]
        [TestCase(65, 0)]
        public void CalculateDemeritPoints_IsInputLessThanOrEqualToSpeedLimit_ReturnsZero(int speed, int result)
        {
            var points = _calculator.CalculateDemeritPoints(speed);
            Assert.That(points, Is.EqualTo(result));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_IsInputSpeedValid_ReturnsDemeritPoint(int speed, int expected)
        {
            var result = _calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}