﻿using Moq;
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
        private Booking _exsistingbooking;
        private Mock<IBookingRepository> _repository;
        [SetUp]
        public void Setup()
        {
            _exsistingbooking = new Booking
            {
                ArrivalDate = ArriveOn(2017, 1, 15),
                DepartureDate = DepartOn(2017, 1, 20),
                Reference = "a",
                Id = 2

            };
            _repository = new Mock<IBookingRepository>();

            _repository.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking>
            {

                _exsistingbooking
            }.AsQueryable());
        }
        [Test]
        public void OverlappingBookingExist_BookingStartAndFinishesBeforeBooking_ReturnEmptyString()
        {
            
            
            var result=BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = Before(_exsistingbooking.ArrivalDate,days:2),
                DepartureDate = Before(_exsistingbooking.ArrivalDate)
            },_repository.Object);
            Assert.That(result, Is.Empty);
        }
        [Test]
        public void OverlappingBookingExist_BookingStartBeforeAndFinishesInTheMiddleOfAnExssitingBooking_ReturnEmptyString()
        {


            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = Before(_exsistingbooking.ArrivalDate),
                DepartureDate = After(_exsistingbooking.ArrivalDate)
            }, _repository.Object);
            Assert.That(result, Is.EqualTo(_exsistingbooking.Reference));
        }
        [Test]
        public void OverlappingBookingExist_BookingStartBeforeAndFinishesAfterAnExssitingBooking_ReturnEmptyString()
        {


            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = Before(_exsistingbooking.ArrivalDate),
                DepartureDate = After(_exsistingbooking.DepartureDate)
            }, _repository.Object);
            Assert.That(result, Is.EqualTo(_exsistingbooking.Reference));
        }
        [Test]
        public void OverlappingBookingExist_BookingStartAndFinishesInTheMiddleOfExssitingBooking_ReturnEmptyString()
        {


            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = After(_exsistingbooking.ArrivalDate),
                DepartureDate = Before(_exsistingbooking.DepartureDate)
            }, _repository.Object);
            Assert.That(result, Is.EqualTo(_exsistingbooking.Reference));
        }
        [Test]
        public void OverlappingBookingExist_BookingStartIntheMiddleBeforeAndFinishesAfterAnExssitingBooking_ReturnEmptyString()
        {


            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = After(_exsistingbooking.ArrivalDate),
                DepartureDate = After(_exsistingbooking.DepartureDate)
            }, _repository.Object);
            Assert.That(result, Is.EqualTo(_exsistingbooking.Reference));
        }
        [Test]
        public void OverlappingBookingExist_BookingStartAndFinishesAfterAnExssitingBooking_ReturnEmptyString()
        {


            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = After(_exsistingbooking.DepartureDate),
                DepartureDate = After(_exsistingbooking.DepartureDate,days:2)
            }, _repository.Object);
            Assert.That(result, Is.Empty);
        }
        [Test]
        public void OverlappingBookingExist_BookingOverLappButNewBookingIsCancelled_ReturnEmptyString()
        {


            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = After(_exsistingbooking.DepartureDate),
                DepartureDate = After(_exsistingbooking.DepartureDate, days: 2),
                Status="Cancalled"
            }, _repository.Object);
            Assert.That(result, Is.Empty);
        }
        private DateTime Before(DateTime dateTime,int days=1)
        {
            return dateTime.AddDays(days);
        }
        private DateTime After(DateTime dateTime,int days=1)
        {
            return dateTime.AddDays(days);
        }
        private DateTime ArriveOn(int year,int month,int day)
        {
            return new DateTime(year, month, day, 14, 0, 0);
        }
        private DateTime DepartOn(int year, int month, int day)
        {
            return new DateTime(year, month, day, 10, 0, 0);
        }
    }
}
