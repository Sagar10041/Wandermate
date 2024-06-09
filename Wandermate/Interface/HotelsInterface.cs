using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Dtos.Hotels;
using Wandermate.Models;

namespace Wandermate.Interface
{
    public interface HotelsInterface
    {
        Task <List<Hotels>> GetAllAsync();
        Task <Hotels?> GetByIdAsync(int id);
        Task <Hotels> CreateAsync(Hotels hotelmodels);

        Task <Hotels?> UpdateAsync (int id, HotelsUpdateRequestDto hotelsdto);
        Task <Hotels?> DeleteAsync (int id);

        Task<bool> HotelExists(int id);

    }
}