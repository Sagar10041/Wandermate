using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wandermate.Models
{
    [Table("Destination")]
    public class Destination
    {
    [Key]
    public int Id { get; set; }

    
      public string Name { get; set; } = String.Empty;

        public decimal Price { get; set; }

        public List<string> Image { get; set; } = new List<string>();

        public string Description { get; set; } = String.Empty;

        public int Rating {get; set;}
        public bool FreeCancellation {get; set;}
    
        public bool ReserveNow {get; set;}
    public List<DestinationReviews> DestinationReviews {get; set;} =new List<DestinationReviews>();

     public List<DestinationBooking> DestinationBookings {get; set;} = new List<DestinationBooking>();
    }
    
}