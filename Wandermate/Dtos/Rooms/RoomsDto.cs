using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Dtos.RoomReviews;
using Wandermate.Models;

namespace Wandermate.Dtos.Rooms
{
    public class RoomsDto
    {
           public int Id { get; set; }

    public string Type { get; set; } = String.Empty;

    public int Beds { get; set; }

    public decimal Price { get; set; } 

    public List<RoomReviewsDto>? RoomReviews {get; set;}

    }
}