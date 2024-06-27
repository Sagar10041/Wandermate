using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Data;
using Wandermate.Interface;
using Wandermate.Models;
using Microsoft.EntityFrameworkCore;

namespace Wandermate.Repos
{
    public class HotelBookingRepo : HotelBookingsInterface
    {
        
        private readonly ApplicationDbContext _context;
        public HotelBookingRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Hotels>> GetUserBookings(AppUser user)
        {
             return await _context.HotelBooking.Where(u => u.AppUserId == user.Id)
            .Select(hotel => new Hotels
            {
                Id  = hotel.Id ,
                Name = hotel.Hotels.Name,
                Price = hotel.Hotels.Price,
                Rating = hotel.Hotels.Rating,
                Description = hotel.Hotels.Description,
                Image= hotel.Hotels.Image,
                FreeCancellation=hotel.Hotels.FreeCancellation,
                ReserveNow=hotel.Hotels.ReserveNow

            }).ToListAsync();
        }

          public async Task<HotelBooking> CreateAsync(HotelBooking hotelBooking)
        {
            await _context.HotelBooking.AddAsync(hotelBooking);
            await _context.SaveChangesAsync();
            return hotelBooking;
        }

        public  async Task<HotelBooking> DeleteBookings(AppUser appUser, string name)
        {
            var hotelBookingModel = await _context.HotelBooking.FirstOrDefaultAsync(x => x.AppUserId == appUser.Id && x.Hotels.Name.ToLower() == name.ToLower());

            if (hotelBookingModel == null)
            {
                return null;
            }

            _context.HotelBooking.Remove(hotelBookingModel);
            await _context.SaveChangesAsync();
            return hotelBookingModel;
        }
    }
}