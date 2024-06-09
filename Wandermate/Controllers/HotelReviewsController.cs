using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wandermate.Data;
using Wandermate.Interface;
using Wandermate.Mappers;

namespace Wandermate.Controllers
{   
    [Route("api/hotelreviews")]
    [ApiController]
    public class HotelReviewsController : ControllerBase

    {   private readonly HotelreviewsInterface _contextrepo;
        public HotelReviewsController(HotelreviewsInterface context)
        {
            _contextrepo = context;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll(){
            var hotelreviews = await _contextrepo.GetAllAsync();
            var hotelreviewsdto = hotelreviews.Select(s=>s.ToHotelReviewDto());
            return Ok(hotelreviewsdto);
        }
        
    }
}