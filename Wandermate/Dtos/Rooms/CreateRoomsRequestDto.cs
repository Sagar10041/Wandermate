using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Models;


namespace Wandermate.Dtos.Rooms
{
    public class CreateRoomsRequestDto
    {
         public string Type { get; set; } = String.Empty;

    public int Beds { get; set; }

    public decimal Price { get; set; } 
    }
}