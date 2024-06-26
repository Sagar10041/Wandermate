using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Models;
using Wandermate.Dtos.Destination;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Wandermate.Mappers
{
    public static class DestinationMappers
    {
         public static DestinationDto ToDestinationDto(this Destination destmodel){

            return new DestinationDto{
                DestinationId= destmodel.DestinationId,
                Name=destmodel.Name,
                Price=destmodel.Price,
                Image=destmodel.Image,
                Description=destmodel.Description,
                Rating=destmodel.Rating,
                FreeCancellation=destmodel.FreeCancellation,
                ReserveNow=destmodel.ReserveNow,
                DestinationReviews=destmodel.DestinationReviews.Select(c => c.ToDestinationReviewDto()).ToList()
                
            };

        }

        public static Destination ToDestinationRequestDto(this CreateDestinationRequestDto reqDto){
            return new Destination{
                 Name=reqDto.Name,
                Price=reqDto.Price,
                Image=reqDto.Image,
                Description=reqDto.Description,
                Rating=reqDto.Rating,
                FreeCancellation=reqDto.FreeCancellation,
                ReserveNow=reqDto.ReserveNow,
            };
        }
    }
}