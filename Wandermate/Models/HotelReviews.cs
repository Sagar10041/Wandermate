using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Models
{
    public class HotelReviews
    {
        [Key]
        public int ReviewId { get; set; }

        public int Rating { get; set; }
        public string ReviewerName { get; set; } =String.Empty;

        public string ReviewText { get; set; } =String.Empty;

        public DateTime CreatedOn {get; set;} = DateTime.Now;
        
        public Hotels? Hotels {get; set;}
    }
}