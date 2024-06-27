using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wandermate.Data;
using Wandermate.Dtos.Destination;
using Wandermate.Interface;
using Wandermate.Models;

namespace Wandermate.Repos
{
    public class DestinationRepo : DestinationInterface
    {
         private readonly ApplicationDbContext _context;

        public DestinationRepo ( ApplicationDbContext dbcontext){
            _context =dbcontext;
        }

        public async Task<Destination> CreateAsync(Destination destmodels)
        {
            await _context.Destination.AddAsync(destmodels);
            await _context.SaveChangesAsync();
            return destmodels;
        }

        public async Task<Destination?> DeleteAsync(int id)
        {
            var destmodels = await _context.Destination.FirstOrDefaultAsync(x => x.Id == id);

            if (destmodels == null){
                return null;
            }
            _context.Destination.Remove(destmodels);
           await _context.SaveChangesAsync();
           return destmodels;

        }

        public async Task<List<Destination>> GetAllAsync()
        {
            return await _context.Destination.Include(c=>c.DestinationReviews).ThenInclude(x=>x.AppUser).ToListAsync();
        }

        public async Task<Destination?> GetByIdAsync(int id)
        {
            return await _context.Destination.Include(c=>c.DestinationReviews).FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<bool> DestinationExists(int id)
        {
            return _context.Destination.AnyAsync(s=> s.Id == id);
        }

        public async Task<Destination?> UpdateAsync(int id, DestinationUpdateRequestDto updatedest)
        {
            var hotel = await _context.Destination.FirstOrDefaultAsync(x=> x.Id ==id);
            if (hotel == null){
                return null;
            }
                hotel.Name = updatedest.Name;
                hotel.Rating=updatedest.Rating;
                hotel.Image=updatedest.Image;
                hotel.Description=updatedest.Description;
                hotel.Price=updatedest.Price;
                hotel.FreeCancellation=updatedest.FreeCancellation;
                hotel.ReserveNow=updatedest.ReserveNow;

             await _context.SaveChangesAsync();
             return hotel;


        }

        public async Task<Destination?> GetByNameAsync(string name)
        {
             return await _context.Destination.FirstOrDefaultAsync(s => s.Name == name);
        }
    }
}