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
        

    }
}