using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Dtos.Rooms
{
    public class RoomsUpdateRequestDto
    {
    public string Type { get; set; } = String.Empty;

    public int Beds { get; set; }

    public decimal Price { get; set; } 
    }
}