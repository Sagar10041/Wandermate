using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Models;

namespace Wandermate.Interface
{
    public interface DestinationReviewsInterface
    {
         Task<List<DestinationReviews>> GetAllAsync();
        Task<DestinationReviews?> GetByIdAsync(int id);
        
        Task< DestinationReviews> CreateAsync(DestinationReviews reviews);

         Task< DestinationReviews?> UpdateAsync(int id,DestinationReviews reviews);

         Task <DestinationReviews?> DeleteAsync (int id);
    }
}