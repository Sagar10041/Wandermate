using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Dtos.DestinationReviews;

namespace Wandermate.Dtos.Destination
{
    public class DestinationDto
    {
        
            public int DestinationId { get; set; }

    
    public string Name { get; set; } = String.Empty;

    public string Address { get; set; }= String.Empty;

    public string City { get; set; } = String.Empty;

    public string Country { get; set; } = String.Empty;

     public List<DestinationReviewsDto>? DestinationReviews {get; set;}
    }
}