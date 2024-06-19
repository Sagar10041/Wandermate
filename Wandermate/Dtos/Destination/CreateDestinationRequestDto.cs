using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate.Dtos.Destination
{
    public class CreateDestinationRequestDto
    {
    
    public string Name { get; set; } = String.Empty;

    public string Address { get; set; }= String.Empty;

    public string City { get; set; } = String.Empty;

    public string Country { get; set; } = String.Empty;
    }
}