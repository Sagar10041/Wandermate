using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Wandermate.Data;
using Wandermate.Dtos.Hotels;
using Wandermate.Mappers;
using Microsoft.EntityFrameworkCore;
using Wandermate.Interface;


namespace Wandermate.Controllers
{
    [Route("api/hotels")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
         private readonly ApplicationDbContext _context;
        private readonly HotelsInterface _hotelsrepo;
        public HotelsController(ApplicationDbContext context, HotelsInterface hotelsrepo)
        {
            _context = context;
            _hotelsrepo= hotelsrepo;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll(){
            var hotels = await _hotelsrepo.GetAllAsync();
            var hoteldto= hotels.Select(s=> s.ToHotelsDto());
            return Ok(hoteldto);
        }

        [HttpGet("{id}")]

        public async Task <IActionResult> GetById([FromRoute] int id){

            var hotel = await _hotelsrepo.GetByIdAsync(id);

            if(hotel== null){
                return NotFound();
            } else{
                return Ok(hotel.ToHotelsDto());
            }

        }

        [HttpPost]

        public async Task <IActionResult> Create([FromBody] CreateHotelsRequestDto hotelrqDto){
            var hotelmodel = hotelrqDto.ToHotelRequestDto();
            await _hotelsrepo.CreateAsync(hotelmodel);
            return CreatedAtAction(nameof(GetById),new {id=hotelmodel.HotelId},hotelmodel.ToHotelsDto());
        }
        
        [HttpPut]

        [Route("{id:int}")]

        public async Task <IActionResult> Update([FromRoute] int id,[FromBody] HotelsUpdateRequestDto updatehotel){
            var hotel= await _hotelsrepo.UpdateAsync(id, updatehotel);
            if(hotel == null){
                return NotFound();
            }
             return Ok(hotel.ToHotelsDto()); 
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task <IActionResult> Delete([FromRoute] int id){
            var hotel = await _hotelsrepo.DeleteAsync(id);
            if (hotel == null){
                return NotFound();
            }
            return NoContent();
        }
    }
}