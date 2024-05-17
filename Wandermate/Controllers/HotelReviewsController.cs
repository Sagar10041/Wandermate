using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wandermate.Data;

namespace Wandermate.Controllers
{   
    [Route("api/hotelreviews")]
    [ApiController]
    public class HotelReviewsController : ControllerBase

    {   private readonly ApplicationDbContext _context;
        public HotelReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult GetAll(){
            var hotelreviews = _context.HotelReviews.ToList();
            return Ok(hotelreviews);
        }

        //  public IActionResult GetById([FromRoute] int id){

        //     var hotelreview = _context.HotelReviews.Find(id);

        //     if(hotelreview== null){
        //         return NotFound();
        //     } else{
        //         return Ok(hotelreview);
        //     }

        // }
        
    }
}