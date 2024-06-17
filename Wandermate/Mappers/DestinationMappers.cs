using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Models;
using Wandermate.Dtos.Destination;

namespace Wandermate.Mappers
{
    public static class DestinationMappers
    {
         public static DestinationDto ToDestinationDto(this Destination destmodel){

            return new DestinationDto{
                DestinationId= destmodel.DestinationId,
                Name=destmodel.Name,
                Address=destmodel.Address,
                City=destmodel.City,
                Country=destmodel.Country,
                DestinationReviews=destmodel.DestinationReviews.Select(c => c.ToDestinationReviewDto()).ToList()
                
            };

        }

        public static Destination ToDestinationRequestDto(this CreateDestinationRequestDto reqDto){
            return new Destination{
                Name=reqDto.Name,
                Address=reqDto.Address,
                City=reqDto.City,
                Country=reqDto.Country
            };
        }
    }
}