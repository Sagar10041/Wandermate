using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wandermate.Dtos.Rooms;
using Wandermate.Models;

namespace Wandermate.Mappers
{
    public static class RoomMappers
    {
        public static RoomsDto ToRoomsDto(this Rooms roommodel){

            return new RoomsDto{
                Id= roommodel.Id,
                Type=roommodel.Type,
                Beds=roommodel.Beds,
                Price=roommodel.Price,
                RoomReviews=roommodel.RoomReviews.Select(c => c.ToRoomReviewDto()).ToList()
                
            };

        }

        public static Rooms ToRoomRequestDto(this CreateRoomsRequestDto reqDto){
            return new Rooms{
                Type=reqDto.Type,
                Beds=reqDto.Beds,
                Price=reqDto.Price,
            };
        }
    }
}