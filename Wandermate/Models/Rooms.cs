using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Models
{
     [Table("Rooms")]
    public class Rooms
    {
        [Key]    
    public int Id { get; set; }

    
    public string Type { get; set; } = String.Empty;

    public int Beds { get; set; }

    public Decimal Price { get; set; } 

    public List<RoomReviews> RoomReviews {get; set;} =new List<RoomReviews>();
    }
}