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
    public int DestinationId { get; set; }

    
    public string Name { get; set; } = String.Empty;

    public string Address { get; set; }= String.Empty;

    public string City { get; set; } = String.Empty;

    public string Country { get; set; } = String.Empty;

    public List<DestinationReviews> DestinationReviews {get; set;} =new List<DestinationReviews>();

     public List<DestinationBooking> DestinationBookings {get; set;} = new List<DestinationBooking>();
    }
    
}