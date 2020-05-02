using Moq;
using System.Linq;
using NUnit.Framework;
using TestNinja.Mocking;
using System;
using System.Collections.Generic;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class BookingHelperTest
    {
        [Test]
        public void OverlappingBookingExist_BookingStartAndFinishesBeforeBooking_ReturnEmptyString()
        {
            var repository = new Mock<IBookingRepository>();
            repository.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking>
            {
                new Booking
                {
                    ArrivalDate=new DateTime(2017,1,15,14,0,0),
                    DepartureDate=new DateTime(2017,1,20,10,0,0),
                    Reference="a",
                    Id=2

                }

            }.AsQueryable());
            var result=BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = new DateTime(2017, 1, 10, 14, 0, 0),
                DepartureDate = new DateTime(2017, 1, 14, 10, 0, 0)
            },repository.Object);
            Assert.That(result, Is.Empty);
        }
    }
}
