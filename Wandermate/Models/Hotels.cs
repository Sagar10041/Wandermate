using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Models
{
    public class Hotels
    {
    [Key]    
    public int HotelId { get; set; }

    
    public string Name { get; set; } = String.Empty;

    public string Address { get; set; }= String.Empty;

    public string City { get; set; } = String.Empty;

    public string Country { get; set; } = String.Empty;

    public List<HotelReviews> HotelReviews {get; set;} =new List<HotelReviews>();
    }
}