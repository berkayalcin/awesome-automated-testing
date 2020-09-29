using Awesome_Automated_Test.Mocking;
using Awesome_Automated_Test.Mocking.Order;
using Moq;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class OrderServiceTests
    {
        private Mock<IStorage> _storage;
        private IOrderService _sut;

        [SetUp]
        public void SetUp()
        {
            _storage = new Mock<IStorage>();

            _sut = new OrderService(_storage.Object);
        }

        [TearDown]
        public void TearDown()
        {
        }


        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var order = new Order();

            _sut.PlaceOrder(order);

            _storage.Verify(s => s.Store(order));
        }
    }
}