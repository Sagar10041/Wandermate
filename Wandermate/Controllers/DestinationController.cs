using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wandermate.Data;
using Wandermate.Interface;
using Wandermate.Mappers;
using Wandermate.Dtos.Destination;

namespace Wandermate.Controllers
{
    [Route("api/Destination")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
          private readonly ApplicationDbContext _context;
        private readonly DestinationInterface _destrepo;
        public DestinationController(ApplicationDbContext context, DestinationInterface destrepo)
        {
            _context = context;
            _destrepo= destrepo;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll(){
            var dest = await _destrepo.GetAllAsync();
            var destdto= dest.Select(s=> s.ToDestinationDto());
            return Ok(destdto);
        }

        [HttpGet("{id}")]

        public async Task <IActionResult> GetById([FromRoute] int id){

            var dest = await _destrepo.GetByIdAsync(id);

            if(dest== null){
                return NotFound();
            } else{
                return Ok(dest.ToDestinationDto());
            }

        }

        [HttpPost]

        public async Task <IActionResult> Create([FromBody] CreateDestinationRequestDto destrqDto){
            var destmodel = destrqDto.ToDestinationRequestDto();
            await _destrepo.CreateAsync(destmodel);
            return CreatedAtAction(nameof(GetById),new {id=destmodel.DestinationId},destmodel.ToDestinationDto());
        }
        
        [HttpPut]

        [Route("{id:int}")]

        public async Task <IActionResult> Update([FromRoute] int id,[FromBody] DestinationUpdateRequestDto updatedest){
            var dest= await _destrepo.UpdateAsync(id, updatedest);
            if(dest == null){
                return NotFound();
            }
            
             return Ok(dest.ToDestinationDto()); 
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task <IActionResult> Delete([FromRoute] int id){

            var hotel = await _destrepo.DeleteAsync(id);
            if (hotel == null){
                return NotFound();

            }
            return NoContent();
        }
    }
}