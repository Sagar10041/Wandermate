using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Dtos.RoomReviews;
using Wandermate.Models;

namespace Wandermate.Mappers
{
    public static class RoomReviewsMapper
    {
        public static RoomReviewsDto ToRoomReviewDto(this RoomReviews roomreviewsModel){
            return new RoomReviewsDto{
                ReviewId= roomreviewsModel.ReviewId,
                Rating= roomreviewsModel.Rating,
                ReviewText=roomreviewsModel.ReviewText,
                CreatedOn=roomreviewsModel.CreatedOn,
               Id=roomreviewsModel.Id

            };
        }

         public static RoomReviews ToReviewsCreate(this RoomReviewCreateDto review,int roomId){
            return new RoomReviews{
                Rating= review.Rating,
                ReviewText=review.ReviewText,
                Id=roomId

            };
        }
        public static RoomReviews ToReviewsUpdate(this RoomReviewsUpdateDto review){
            return new RoomReviews{
                Rating= review.Rating,
                ReviewText=review.ReviewText

            };
        }
    }
}