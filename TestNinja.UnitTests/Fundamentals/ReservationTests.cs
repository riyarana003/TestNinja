using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange - initial our objects - objects we wanna test
            var reservation = new Reservation();
            
            //Act
            var result = reservation.CanBeCancelledBy(new User {IsAdmin = true });
            
            //Assert
            Assert.That(result,Is.True);  //Assert.IsTrue(resullt);
        }

        [Test]
        public void CanBeCancelledBy_SameUserWhoMadeReservation_CancellingIt_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            var resullt = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(resullt);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
        }
    }
}
