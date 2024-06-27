using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Models;

namespace Wandermate.Interface
{
    public interface HotelBookingsInterface
    {
        Task<List<Hotels>> GetUserBookings(AppUser user);

          Task<HotelBooking> CreateAsync(HotelBooking hotelBooking);

          Task<HotelBooking> DeleteBookings(AppUser appUser, string name);
    }
}