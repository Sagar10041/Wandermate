using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Models
{
    public class HotelBooking
    {
         public string AppUserId {get; set;}
        public int Id {get; set;}

        public AppUser AppUser {get; set;}

        public Hotels Hotels{get; set;}
    }
}