using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Dtos.Destination;
using Wandermate.Models;

namespace Wandermate.Interface
{
    public interface DestinationInterface
    {
         Task <List<Destination>> GetAllAsync();
        Task <Destination?> GetByIdAsync(int id);
        Task <Destination> CreateAsync(Destination destmodels);

        Task <Destination?> UpdateAsync (int id, DestinationUpdateRequestDto destdto);
        Task <Destination?> DeleteAsync (int id);

        Task<bool> DestinationExists(int id);

         Task<Destination?> GetByNameAsync(string name);
    }
}