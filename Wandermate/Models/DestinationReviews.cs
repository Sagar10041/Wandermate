using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Wandermate.Models
{
    public class DestinationReviews
    {
        [Key]
        public int DestinationReviewId { get; set; }

        public int Rating { get; set; }

        public string ReviewText { get; set; } =String.Empty;

        public DateTime CreatedOn {get; set;} = DateTime.Now;
        
        public int? DestinationId {get; set;}
        public Destination? Destination {get; set;}
    }
}