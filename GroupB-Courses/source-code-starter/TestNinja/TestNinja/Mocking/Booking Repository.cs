using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    class Booking_Repository : IBooking_Repository
    {
        public IQueryable<Booking> GetActiveBookings(int? excludedbookingId = null)
        {
            var unitOfWork = new UnitOfWork();
            var bookings =
                unitOfWork.Query<Booking>()
                    .Where(
                        b => b.Status != "Cancelled");
            if (excludedbookingId.HasValue)
            {
                bookings = bookings.Where(b => b.Id != excludedbookingId.Value);
            }
            return bookings;
        }
    }
}
