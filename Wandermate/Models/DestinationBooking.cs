using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Models
{
     [Table("DestinationBooking")]
    public class DestinationBooking
    {
        public string AppUserId {get; set;}
        public int Id {get; set;}

        public AppUser AppUser{get; set;}

        public Destination Destination{get; set;}

    }
}