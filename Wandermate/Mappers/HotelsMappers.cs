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
                Address=hotelmodel.Address,
                City=hotelmodel.City,
                Country=hotelmodel.Country,
                HotelReviews = hotelmodel.HotelReviews.Select(c=>c.ToHotelReviewDto()).ToList()
                
            };

        }

        public static Hotels ToHotelRequestDto(this CreateHotelsRequestDto reqDto){
            return new Hotels{
                Name=reqDto.Name,
                Address=reqDto.Address,
                City=reqDto.City,
                Country=reqDto.Country
            };
        }
    }

    
}