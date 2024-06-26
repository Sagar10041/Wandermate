using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wandermate.Data;
using Wandermate.Interface;
using Wandermate.Models;

namespace Wandermate.Repos
{
    public class DestinationBookingRepo : DestinationBookingsInterface
    {

        private readonly ApplicationDbContext _context;
        public DestinationBookingRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Destination>> GetUserBookings(AppUser user)
        {
             return await _context.DestinationBookings.Where(u => u.AppUserId == user.Id)
            .Select(dest => new Destination
            {
               Id  = dest.Id ,
                Name = dest.Destination.Name,
                Price = dest.Destination.Price,
                Rating = dest.Destination.Rating,
                Description = dest.Destination.Description,
                Image= dest.Destination.Image,
                FreeCancellation=dest.Destination.FreeCancellation,
                ReserveNow=dest.Destination.ReserveNow

            }).ToListAsync();
        }

          public async Task<DestinationBooking> CreateAsync(DestinationBooking destinationBooking)
        {
            await _context.DestinationBookings.AddAsync(destinationBooking);
            await _context.SaveChangesAsync();
            return destinationBooking;
        }

        public  async Task<DestinationBooking> DeleteBookings(AppUser appUser, string name)
        {
            var destBookingModel = await _context.DestinationBookings.FirstOrDefaultAsync(x => x.AppUserId == appUser.Id && x.Destination.Name.ToLower() == name.ToLower());

            if (destBookingModel == null)
            {
                return null;
            }

            _context.DestinationBookings.Remove(destBookingModel);
            await _context.SaveChangesAsync();
            return destBookingModel;
        }
    }
}