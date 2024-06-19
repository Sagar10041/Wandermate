using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Models;

namespace Wandermate.Interface
{
    public interface RoomReviewsInterface
    {
         Task<List<RoomReviews>> GetAllAsync();
        Task<RoomReviews?> GetByIdAsync(int id);
        
        Task< RoomReviews> CreateAsync(RoomReviews reviews);

         Task<RoomReviews?> UpdateAsync(int id,RoomReviews reviews);

         Task <RoomReviews?> DeleteAsync (int id);

    }
}