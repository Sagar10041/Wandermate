using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Dtos.Hotels;
using Wandermate.Models;

namespace Wandermate.Mappers
{
    public static class HotelsMappers
    {
        public static HotelsDto ToHotelsDto(this Hotels hotelmodel){

            return new HotelsDto{
                HotelId= hotelmodel.HotelId,
                Name=hotelmodel.Name,
                Price=hotelmodel.Price,
                Image=hotelmodel.Image,
                Rating=hotelmodel.Rating,
                FreeCancellation=hotelmodel.FreeCancellation,
                ReserveNow=hotelmodel.ReserveNow,
                Description=hotelmodel.Description,
                HotelReviews=hotelmodel.HotelReviews.Select(c => c.ToHotelReviewDto()).ToList()
                
            };
        }

        public static Hotels ToHotelRequestDto(this CreateHotelsRequestDto reqDto){
            return new Hotels{
                Name=reqDto.Name,
                Price=reqDto.Price,
                Image=reqDto.Image,
                Rating=reqDto.Rating,
                FreeCancellation=reqDto.FreeCancellation,
                ReserveNow=reqDto.ReserveNow,
                Description=reqDto.Description,
            };
        }
    }

    
}