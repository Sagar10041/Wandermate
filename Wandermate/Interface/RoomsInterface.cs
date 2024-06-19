using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Models;
using Wandermate.Dtos.Rooms;

namespace Wandermate.Interface
{
    public interface RoomsInterface
    {
         Task <List<Rooms>> GetAllAsync();
        Task <Rooms?> GetByIdAsync(int id);
        Task <Rooms> CreateAsync(Rooms roommodels);

        Task <Rooms?> UpdateAsync (int id, RoomsUpdateRequestDto roomdto);
        Task <Rooms?> DeleteAsync (int id);

        Task<bool> RoomExists(int id);

    }
}