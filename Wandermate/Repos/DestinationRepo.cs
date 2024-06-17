using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wandermate.Data;
using Wandermate.Dtos.Destination;
using Wandermate.Interface;
using Wandermate.Migrations;
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
            var destmodels = await _context.Destination.FirstOrDefaultAsync(x => x.DestinationId == id);

            if (destmodels == null){
                return null;
            }
            _context.Destination.Remove(destmodels);
           await _context.SaveChangesAsync();
           return destmodels;

        }

        public async Task<List<Destination>> GetAllAsync()
        {
            return await _context.Destination.Include(c=>c.DestinationReviews).ToListAsync();
        }

        public async Task<Destination?> GetByIdAsync(int id)
        {
            return await _context.Destination.Include(c=>c.DestinationReviews).FirstOrDefaultAsync(i => i.DestinationId == id);
        }

        public Task<bool> DestinationExists(int id)
        {
            return _context.Destination.AnyAsync(s=> s.DestinationId == id);
        }

        public async Task<Destination?> UpdateAsync(int id, DestinationUpdateRequestDto updatedest)
        {
            var hotel = await _context.Destination.FirstOrDefaultAsync(x=> x.DestinationId ==id);
            if (hotel == null){
                return null;
            }
            hotel.Name = updatedest.Name;
                hotel.City=updatedest.City;
                hotel.Address=updatedest.Address;
                hotel.Country=updatedest.Country;

             await _context.SaveChangesAsync();
             return hotel;


        }
    }
}