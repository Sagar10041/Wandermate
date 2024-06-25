using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Wandermate.Models
{
     [Table("Hotels")]
    public class Hotels
    {
    [Key]    
        public int HotelId { get; set; }
        
        public string Name { get; set; } = String.Empty;

        public int Price { get; set; }

        public List<string> Image {get; set;} = new List<string>();

        public int Rating { get; set; }

        public bool FreeCancellation {get; set; }

        public bool ReserveNow {get; set;}

        public string Description { get; set; } = String.Empty;

    public List<HotelReviews> HotelReviews {get; set;} =new List<HotelReviews>();
    }
}