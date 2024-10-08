using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wandermate.Data;
using Wandermate.Dtos.Hotels;
using Wandermate.Interface;
using Wandermate.Models;
using Microsoft.AspNetCore.Identity;
using Wandermate.Extensions;

namespace Wandermate.Repos
{
    public class HotelsRepo : HotelsInterface
    {   
        private readonly ApplicationDbContext _context;

        public HotelsRepo ( ApplicationDbContext dbcontext){
            _context =dbcontext;
        }

        public async Task<Hotels> CreateAsync(Hotels hotelmodels)
        {
            await _context.Hotels.AddAsync(hotelmodels);
            await _context.SaveChangesAsync();
            return hotelmodels;
        }

        public async Task<Hotels?> DeleteAsync(int id)
        {
            var hotelmodels = await _context.Hotels.FirstOrDefaultAsync(x => x.Id == id);

            if (hotelmodels == null){
                return null;
            }
            _context.Hotels.Remove(hotelmodels);
           await _context.SaveChangesAsync();
           return hotelmodels;

        }

        public async Task<List<Hotels>> GetAllAsync()
        {
            return await _context.Hotels.Include(c=>c.HotelReviews).ThenInclude(x=>x.AppUser).ToListAsync();
        }

        public async Task<Hotels?> GetByIdAsync(int id)
        {
            return await _context.Hotels.Include(c=>c.HotelReviews).FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<bool> HotelExists(int id)
        {
            return _context.Hotels.AnyAsync(s=> s.Id == id);
        }

        public async Task<Hotels?> UpdateAsync(int id, HotelsUpdateRequestDto updatehotel)
        {
            var hotel = await _context.Hotels.FirstOrDefaultAsync(x=> x.Id ==id);
            if (hotel == null){
                return null;
            }
            hotel.Name = updatehotel.Name;
                hotel.Price=updatehotel.Price;
                hotel.Image=updatehotel.Image;
                hotel.Description=updatehotel.Description;
                hotel.Rating=updatehotel.Rating;
                hotel.FreeCancellation=updatehotel.FreeCancellation;
                hotel.ReserveNow=updatehotel.ReserveNow;

             await _context.SaveChangesAsync();
             return hotel;


        }
         public async Task<Hotels?> GetByNameAsync(string name)
        {
             return await _context.Hotels.FirstOrDefaultAsync(s => s.Name == name);
        }
    }
}