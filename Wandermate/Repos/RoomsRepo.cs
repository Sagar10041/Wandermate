using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wandermate.Data;
using Wandermate.Dtos.Rooms;
using Wandermate.Interface;
using Wandermate.Models;

namespace Wandermate.Repos
{
    public class RoomsRepo : RoomsInterface
    {
         private readonly ApplicationDbContext _context;

        public RoomsRepo ( ApplicationDbContext dbcontext){
            _context =dbcontext;
        }

        public async Task<Rooms> CreateAsync(Rooms roommodels)
        {
            await _context.Rooms.AddAsync(roommodels);
            await _context.SaveChangesAsync();
            return roommodels;
        }

        public async Task<Rooms?> DeleteAsync(int id)
        {
            var roommodels = await _context.Rooms.FirstOrDefaultAsync(x => x.Id == id);

            if (roommodels == null){
                return null;
            }
            _context.Rooms.Remove(roommodels);
           await _context.SaveChangesAsync();
           return roommodels;

        }

        public async Task<List<Rooms>> GetAllAsync()
        {
            return await _context.Rooms.Include(c=>c.RoomReviews).ToListAsync();
        }

        public async Task<Rooms?> GetByIdAsync(int id)
        {
            return await _context.Rooms.Include(c=>c.RoomReviews).FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<bool> RoomExists(int id)
        {
            return _context.Rooms.AnyAsync(s=> s.Id == id);
        }

        public async Task<Rooms?> UpdateAsync(int id, RoomsUpdateRequestDto updateroom)
        {
            var room = await _context.Rooms.FirstOrDefaultAsync(x=> x.Id ==id);
            if (room == null){
                return null;
            }
            room.Type = updateroom.Type;
                room.Beds=updateroom.Beds;
                room.Price=updateroom.Price;

             await _context.SaveChangesAsync();
             return room;


        }
    }
}