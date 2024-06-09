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


namespace Wandermate.Controllers
{
    [Route("api/hotels")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
         private readonly ApplicationDbContext _context;

        public HotelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll(){
            var hotels = await _context.Hotels.ToListAsync();
            var hoteldto= hotels.Select(s=> s.ToHotelsDto());
            return Ok(hoteldto);
        }

        [HttpGet("{id}")]

        public async Task <IActionResult> GetById([FromRoute] int id){

            var hotel = await _context.Hotels.FindAsync(id);

            if(hotel== null){
                return NotFound();
            } else{
                return Ok(hotel.ToHotelsDto());
            }

        }

        [HttpPost]

        public async Task <IActionResult> Create([FromBody] CreateHotelsRequestDto hotelrqDto){
            var hotelmodel = hotelrqDto.ToHotelRequestDto();
            await _context.Hotels.AddAsync(hotelmodel);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById),new {id=hotelmodel.HotelId},hotelmodel.ToHotelsDto());
        }
        
        [HttpPut]

        [Route("{id:int}")]

        public async Task <IActionResult> Update([FromRoute] int id,[FromBody] HotelsUpdateRequestDto updatehotel){
            var hotel= await _context.Hotels.FirstOrDefaultAsync(x=> x.HotelId == id);
            if(hotel == null){
                return NotFound();
            }
                hotel.Name = updatehotel.Name;
                hotel.City=updatehotel.City;
                hotel.Address=updatehotel.Address;
                hotel.Country=updatehotel.Country;

             await _context.SaveChangesAsync();
             return Ok(hotel.ToHotelsDto()); 
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task <IActionResult> Delete([FromRoute] int id){

            var hotel = await _context.Hotels.FirstOrDefaultAsync(x=> x.HotelId == id);
            if (hotel == null){
                return NotFound();

            }
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}