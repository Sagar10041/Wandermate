using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Wandermate.Models
{
    public class Destination
    {
    [Key]
    public int DestinationId { get; set; }

    
    public string Name { get; set; } = String.Empty;

    public string Address { get; set; }= String.Empty;

    public string City { get; set; } = String.Empty;

    public string Country { get; set; } = String.Empty;

    public List<DestinationReviews> DestinationReviews {get; set;} =new List<DestinationReviews>();
    }
    
}