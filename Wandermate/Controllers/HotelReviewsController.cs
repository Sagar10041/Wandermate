using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wandermate.Data;
using Wandermate.Dtos.HotelReviews;
using Wandermate.Interface;
using Wandermate.Mappers;

namespace Wandermate.Controllers
{   
    [Route("api/hotelreviews")]
    [ApiController]
    public class HotelReviewsController : ControllerBase

    {   private readonly HotelreviewsInterface _contextrepo;
        private readonly HotelsInterface _hotels;
        public HotelReviewsController(HotelreviewsInterface context, HotelsInterface hotels)
        {
            _contextrepo = context;
            _hotels=hotels;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll(){
            var hotelreviews = await _contextrepo.GetAllAsync();
            var hotelreviewsdto = hotelreviews.Select(s=>s.ToHotelReviewDto());
            return Ok(hotelreviewsdto);
        }
        
        [HttpGet("{id}")]

        public async Task <IActionResult> GetById([FromRoute] int id){
            var review = await _contextrepo.GetByIdAsync(id);

            if (review == null){
                return NotFound();
            }
            return Ok(review.ToHotelReviewDto());
        }

        [HttpPost("{id}")]

        public async Task<IActionResult> Create([FromRoute] int id, HotelReviewCreateDto revDto){

            if (!await _hotels.HotelExists(id)){
                return BadRequest("Hotel doesnot exist");
            }
            var review = revDto.ToReviewsCreate(id);
            await _contextrepo.CreateAsync(review);
            return CreatedAtAction(nameof(GetById), new {id = review.Id }, review.ToHotelReviewDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] HotelreviewsUpdateDto updatereviews){
            var review = await _contextrepo.UpdateAsync(id, updatereviews.ToReviewsUpdate());
            if(review == null){
                return NotFound("Hotel not found");
            }
            return Ok(review.ToHotelReviewDto());

        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task <IActionResult> Delete([FromRoute] int id){

            var hotel = await _contextrepo.DeleteAsync(id);
            if (hotel == null){
                return NotFound();

            }
            return NoContent();
        }

    }
}