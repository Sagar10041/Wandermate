using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wandermate.Models
{ [Table("DestinationReviews")]
    public class DestinationReviews
    {
        [Key]
        public int ReviewId { get; set; }

        public int Rating { get; set; }

        public string ReviewText { get; set; } =String.Empty;

        public DateTime CreatedOn {get; set;} = DateTime.Now;
        
        public int? Id {get; set;}
        public Destination? Destination {get; set;}
    }
}