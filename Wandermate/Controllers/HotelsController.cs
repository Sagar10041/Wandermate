using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Wandermate.Data;
using Wandermate.Dtos.Hotels;
using Wandermate.Mappers;


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

        public IActionResult GetAll(){
            var hotels = _context.Hotels.ToList()
            .Select(s=> s.ToHotelsDto());
            return Ok(hotels);
        }

        [HttpGet("{id}")]

        public IActionResult GetById([FromRoute] int id){

            var hotel = _context.Hotels.Find(id);

            if(hotel== null){
                return NotFound();
            } else{
                return Ok(hotel.ToHotelsDto());
            }

        }

        [HttpPost]

        public IActionResult Create([FromBody] CreateHotelsRequestDto hotelrqDto){
            var hotelmodel = hotelrqDto.ToHotelRequestDto();
            _context.Hotels.Add(hotelmodel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById),new {id=hotelmodel.HotelId},hotelmodel.ToHotelsDto());
        }
        
        [HttpPut]

        [Route("{id:int}")]

        public IActionResult Update([FromRoute] int id,[FromBody] HotelsUpdateRequestDto updatehotel){
            var hotel=_context.Hotels.FirstOrDefault(x=> x.HotelId == id);
            if(hotel == null){
                return NotFound();
            }
                hotel.Name = updatehotel.Name;
                hotel.City=updatehotel.City;
                hotel.Address=updatehotel.Address;
                hotel.Country=updatehotel.Country;

             _context.SaveChanges();
             return Ok(hotel.ToHotelsDto()); 
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id){

            var hotel = _context.Hotels.FirstOrDefault(x=> x.HotelId == id);
            if (hotel == null){
                return NotFound();

            }
            _context.Hotels.Remove(hotel);
            _context.SaveChanges();
            return NoContent();
        }
    }
}