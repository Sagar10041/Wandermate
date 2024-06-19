using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Models
{
    public class Rooms
    {
        [Key]    
    public int RoomId { get; set; }

    
    public string Type { get; set; } = String.Empty;

    public int Beds { get; set; }

    public Decimal Price { get; set; } 

    public List<RoomReviews> RoomReviews {get; set;} =new List<RoomReviews>();
    }
}