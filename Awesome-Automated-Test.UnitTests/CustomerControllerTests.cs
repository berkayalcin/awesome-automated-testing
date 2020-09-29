using Awesome_Automated_Test.Fundamentals;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new CustomerController();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void GetCustomer_IdIsZero_ShouldReturnNotFound()
        {
            var result = _controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ShouldReturnOk()
        {
            var result = _controller.GetCustomer(5);
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}