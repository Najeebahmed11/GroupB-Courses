using System;
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
            //arrange
            var reservation = new Reservation();
            //act
            var result=reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //assert
            Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_SameUserCanceelingTheReservation_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation{ MadeBy = user};
            var reslt=reservation.CanBeCancelledBy(user);
            Assert.IsTrue(reslt);
        }
        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            var reservation=new Reservation { MadeBy=new User()};
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }

}
