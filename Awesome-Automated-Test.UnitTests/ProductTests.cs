using Awesome_Automated_Test.Mocking.Customer;
using Awesome_Automated_Test.Mocking.Product;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class ProductTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            var product = new Product()
            {
                ListPrice = 100
            };

            var result = product.GetPrice(new Customer()
            {
                IsGold = true
            });

            Assert.That(result, Is.EqualTo(70f));
        }

        [Test]
        public void GetPrice_IsNotGoldCustomer_ApplyNoDiscount()
        {
            var product = new Product()
            {
                ListPrice = 100
            };

            var result = product.GetPrice(new Customer()
            {
                IsGold = false
            });

            Assert.That(result, Is.EqualTo(100.0f));
        }
    }
}