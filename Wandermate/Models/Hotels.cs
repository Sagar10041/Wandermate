using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Models
{
     [Table("Hotels")]
    public class Hotels
    {
    [Key]    
    public int HotelId { get; set; }

    
    public string Name { get; set; } = String.Empty;

    public decimal Price { get; set; }

    public string Image { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public int Rating {get; set;}
    public bool FreeCancellation {get; set;}
    
    public bool ReserveNow {get; set;}

    public List<HotelReviews> HotelReviews {get; set;} =new List<HotelReviews>();
    }
}