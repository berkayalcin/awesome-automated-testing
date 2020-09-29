using Awesome_Automated_Test.Fundamentals;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;

        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }

        [Test]
        [TestCase("Some Errors")]
        public void Log_WhenCalledWithValidMessage_SetTheLastErrorProperty(string errorMessage)
        {
            _logger.Log(errorMessage);

            Assert.That(_logger.LastError, Is.EqualTo(errorMessage));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void Log_WhenCalledWithInvalidMessage_ThrowArgumentNullException(string errorMessage)
        {
            Assert.That(() => _logger.Log(errorMessage), Throws.ArgumentNullException);
        }
    }
}