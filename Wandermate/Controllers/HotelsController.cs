using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wandermate.Data;


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
            var hotels = _context.Hotels.ToList();
            return Ok(hotels);
        }

        [HttpGet("{id}")]

        public IActionResult GetById([FromRoute] int id){

            var hotel = _context.Hotels.Find(id);

            if(hotel== null){
                return NotFound();
            } else{
                return Ok(hotel);
            }

        }
        

    }
}