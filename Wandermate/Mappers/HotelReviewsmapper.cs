using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Dtos.HotelReviews;
using Wandermate.Models;

namespace Wandermate.Mappers
{
    public static class HotelReviewsmapper
    {
        public static HotelReviewDti ToHotelReviewDto(this HotelReviews hotelreviewsModel){
            return new HotelReviewDti{
                ReviewId= hotelreviewsModel.ReviewId,
                Rating= hotelreviewsModel.Rating,
                ReviewText=hotelreviewsModel.ReviewText,
                CreatedOn=hotelreviewsModel.CreatedOn,
                HotelId=hotelreviewsModel.HotelId

            };
        }
    }
}