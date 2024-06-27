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
               Id= hotelmodel.Id,
                Name=hotelmodel.Name,
                Price=hotelmodel.Price,
                Image=hotelmodel.Image,
                Description=hotelmodel.Description,
                Rating=hotelmodel.Rating,
                FreeCancellation=hotelmodel.FreeCancellation,
                ReserveNow=hotelmodel.FreeCancellation,
                HotelReviews=hotelmodel.HotelReviews.Select(c => c.ToHotelReviewDto()).ToList()
                
            };
        }

        public static Hotels ToHotelRequestDto(this CreateHotelsRequestDto reqDto){
            return new Hotels{
               Name=reqDto.Name,
                Price=reqDto.Price,
                Image=reqDto.Image,
                Description=reqDto.Description,
                Rating=reqDto.Rating,
                FreeCancellation=reqDto.FreeCancellation,
                ReserveNow=reqDto.FreeCancellation,
            };
        }
    }

    
}