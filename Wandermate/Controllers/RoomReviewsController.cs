using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wandermate.Data;
using Wandermate.Dtos.RoomReviews;
using Wandermate.Interface;
using Wandermate.Mappers;

namespace Wandermate.Controllers
{[Route("api/roomreviews")]
    [ApiController]
    public class RoomReviewsController: ControllerBase
    {
         private readonly RoomReviewsInterface _contextrepo;
        private readonly RoomsInterface _room;
        public RoomReviewsController(RoomReviewsInterface context, RoomsInterface room)
        {
            _contextrepo = context;
            _room=room;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll(){
            var roomreviews = await _contextrepo.GetAllAsync();
            var roomreviewsdto = roomreviews.Select(s=>s.ToRoomReviewDto());
            return Ok(roomreviewsdto);
        }
        
        [HttpGet("{id}")]

        public async Task <IActionResult> GetById([FromRoute] int id){
            var review = await _contextrepo.GetByIdAsync(id);

            if (review == null){
                return NotFound();
            }
            return Ok(review.ToRoomReviewDto());
        }

        [HttpPost("{id}")]

        public async Task<IActionResult> Create([FromRoute] int id, RoomReviewCreateDto revDto){

            if (!await _room.RoomExists(id)){
                return BadRequest("Room doesnot exist");
            }
            var review = revDto.ToReviewsCreate(id);
            await _contextrepo.CreateAsync(review);
            return CreatedAtAction(nameof(GetById), new {id = review.RoomId }, review.ToRoomReviewDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] RoomReviewsUpdateDto updatereviews){
            var review = await _contextrepo.UpdateAsync(id, updatereviews.ToReviewsUpdate());
            if(review == null){
                return NotFound("Room not found");
            }
            return Ok(review.ToRoomReviewDto());

        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task <IActionResult> Delete([FromRoute] int id){

            var room = await _contextrepo.DeleteAsync(id);
            if (room == null){
                return NotFound();

            }
            return NoContent();
        }

    }
}