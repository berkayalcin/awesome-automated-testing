using Awesome_Automated_Test.Fundamentals;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange

            var reservation = new Reservation();

            // Act

            var result = reservation.CanBeCancelledBy(new User()
            {
                IsAdmin = true
            });

            // Assert / Verify

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            var madeBy = new User();
            var reservation = new Reservation()
            {
                MadeBy = madeBy
            };


            var result = reservation.CanBeCancelledBy(madeBy);


            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            var madeBy = new User();
            var reservation = new Reservation()
            {
                MadeBy = madeBy
            };


            var result = reservation.CanBeCancelledBy(new User());


            Assert.That(result, Is.False);
        }
    }
}