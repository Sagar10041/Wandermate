using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Models
{   
     [Table("RoomReviews")]
    public class RoomReviews
    {
         [Key]
        public int ReviewId { get; set; }

        public int Rating { get; set; }

        public string ReviewText { get; set; } =String.Empty;

        public DateTime CreatedOn {get; set;} = DateTime.Now;
          
        public int? RoomId {get; set;}
        public Rooms? Rooms {get; set;}
    }
}