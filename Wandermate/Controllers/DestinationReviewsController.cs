using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wandermate.Data;
using Wandermate.Dtos.DestinationReviews;
using Wandermate.Interface;
using Wandermate.Mappers;


namespace Wandermate.Controllers
{
    [Route("api/DestinationReviews")]
    [ApiController]
    public class DestinationReviewsController : ControllerBase
    {
         private readonly DestinationReviewsInterface _contextrepo;
        private readonly DestinationInterface _dest;
        public DestinationReviewsController(DestinationReviewsInterface context, DestinationInterface dest)
        {
            _contextrepo = context;
            _dest=dest;
        }

        [HttpGet]
        [Authorize]

        public async Task<IActionResult> GetAll(){
            var destreviews = await _contextrepo.GetAllAsync();
            var destinationreviewsdto = destreviews.Select(s=>s.ToDestinationReviewDto());
            return Ok(destinationreviewsdto);
        }
        
        [HttpGet("{id}")]
        [Authorize]

        public async Task <IActionResult> GetById([FromRoute] int id){
            var review = await _contextrepo.GetByIdAsync(id);

            if (review == null){
                return NotFound();
            }
            return Ok(review.ToDestinationReviewDto());
        }

        [HttpPost("{id}")]
        [Authorize]

        public async Task<IActionResult> Create([FromRoute] int id, DestinationReviewCreateDto revDto){

            if (!await _dest.DestinationExists(id)){
                return BadRequest("Destination doesnot exist");
            }
            var review = revDto.ToReviewsCreate(id);
            await _contextrepo.CreateAsync(review);
            return CreatedAtAction(nameof(GetById), new {id = review.Id }, review.ToDestinationReviewDto());
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] DestinationreviewsUpdateDto updatereviews){
            var review = await _contextrepo.UpdateAsync(id, updatereviews.ToReviewsUpdate());
            if(review == null){
                return NotFound("Destination not found");
            }
            return Ok(review.ToDestinationReviewDto());

        }

        [HttpDelete]
        [Route("{id:int}")]
        [Authorize]
        public async Task <IActionResult> Delete([FromRoute] int id){

            var hotel = await _contextrepo.DeleteAsync(id);
            if (hotel == null){
                return NotFound();

            }
            return NoContent();
        }
    }
}