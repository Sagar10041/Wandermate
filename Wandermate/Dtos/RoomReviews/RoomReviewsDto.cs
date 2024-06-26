using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Dtos.RoomReviews
{
    public class RoomReviewsDto
    {
        public int ReviewId { get; set; }

        public int Rating { get; set; }

        public string ReviewText { get; set; } =String.Empty;

        public DateTime CreatedOn {get; set;} = DateTime.Now;
        
         public int? Id {get; set;}
   
    }
}