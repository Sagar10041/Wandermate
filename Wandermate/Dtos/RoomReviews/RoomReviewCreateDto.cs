using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Dtos.RoomReviews
{
    public class RoomReviewCreateDto
    {
         public int Rating { get; set; }

        public string ReviewText { get; set; } =String.Empty;

    }
}