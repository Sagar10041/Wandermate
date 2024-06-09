using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Models;

namespace Wandermate.Interface
{
    public interface HotelreviewsInterface
    {
        Task<List<HotelReviews>> GetAllAsync();
        Task<HotelReviews?> GetByIdAsync(int id);
        
        Task< HotelReviews> CreateAsync(HotelReviews reviews);

         Task< HotelReviews?> UpdateAsync(int id,HotelReviews reviews);

         Task <HotelReviews?> DeleteAsync (int id);


    }

}