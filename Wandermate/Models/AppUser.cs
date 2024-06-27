using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Net.Http.Headers;

namespace Wandermate.Models
{
    public class AppUser : IdentityUser
    {
        public List<DestinationBooking> DestinationBookings {get; set;} = new List<DestinationBooking>();
        
        public List<HotelBooking> HotelBooking {get; set;} = new List<HotelBooking>();
    }
}