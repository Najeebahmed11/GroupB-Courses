using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrange
            var reservation = new Reservation();
            //act
            var result=reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_SameUserCanceelingTheReservation_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation{ MadeBy = user};
            var reslt=reservation.CanBeCancelledBy(user);
            Assert.IsTrue(reslt);
        }
        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            var reservation=new Reservation { MadeBy=new User()};
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }

}
