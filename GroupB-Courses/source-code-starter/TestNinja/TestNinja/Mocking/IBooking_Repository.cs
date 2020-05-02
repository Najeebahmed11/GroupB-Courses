using System.Linq;

namespace TestNinja.Mocking
{
    interface IBooking_Repository
    {
        IQueryable<Booking> GetActiveBookings(int? excludedbookingId = null);
    }
}