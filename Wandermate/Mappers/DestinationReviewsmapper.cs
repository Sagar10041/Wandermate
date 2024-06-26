using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Dtos.DestinationReviews;
using Wandermate.Models;


namespace Wandermate.Mappers
{
    public static class DestinationReviewsmapper
    {
        
        public static DestinationReviewsDto ToDestinationReviewDto(this DestinationReviews destinationreviewsModel){
            return new DestinationReviewsDto{
                ReviewId= destinationreviewsModel.ReviewId,
                Rating= destinationreviewsModel.Rating,
                ReviewText=destinationreviewsModel.ReviewText,
                CreatedOn=destinationreviewsModel.CreatedOn,
               Id=destinationreviewsModel.Id

            };
        }

         public static DestinationReviews ToReviewsCreate(this DestinationReviewCreateDto review,int destId){
            return new DestinationReviews{
                Rating= review.Rating,
                ReviewText=review.ReviewText,
               Id=destId

            };
        }
        public static DestinationReviews ToReviewsUpdate(this DestinationreviewsUpdateDto review){
            return new DestinationReviews{
                Rating= review.Rating,
                ReviewText=review.ReviewText

            };
        }
    }
}