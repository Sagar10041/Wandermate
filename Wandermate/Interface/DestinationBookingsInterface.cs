using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Models;

namespace Wandermate.Interface
{
    public interface DestinationBookingsInterface
    {
          Task<List<Destination>> GetUserBookings(AppUser user);
    }
}