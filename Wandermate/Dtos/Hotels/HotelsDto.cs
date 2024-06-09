using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Dtos.HotelReviews;

namespace Wandermate.Dtos.Hotels
{
    public class HotelsDto
    {
            public int HotelId { get; set; }

    
    public string Name { get; set; } = String.Empty;

    public string Address { get; set; }= String.Empty;

    public string City { get; set; } = String.Empty;

    public string Country { get; set; } = String.Empty;

    // public List<HotelReviewDti> HotelReviews {get; set;}
    }
}