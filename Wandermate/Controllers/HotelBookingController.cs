using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Wandermate.Interface;
using Wandermate.Models;
using Wandermate.Repos;
using Wandermate.Extensions;


namespace Wandermate.Controllers
{ [Route("api/HotelBooking")]
    [ApiController]
    public class HotelBookingController
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly HotelsInterface _hotelRepo;
         private readonly HotelBookingsInterface _hotelBookingRepo;

        public HotelBookingController(HotelsInterface hotelRepo,UserManager <AppUser> userManager,HotelBookingsInterface hotelBookingRepo)
        {
              _userManager = userManager;
            _hotelRepo = hotelRepo;
            _hotelBookingRepo = hotelBookingRepo;
        }

       
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUserBookings()
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var userBookings = await  _hotelBookingRepo.GetUserBookings(appUser);
            return Ok(userBookings);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddHotelBookings(string name)
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var dest = await _hotelRepo.GetByNameAsync(name);

           

            if (dest == null) return BadRequest("Destination not found");

            var userBooking = await  _hotelBookingRepo.GetUserBookings(appUser);

            if (userBooking.Any(e => e.Name.ToLower() == name.ToLower())) return BadRequest("Cannot add same hotel to bookings");

            var destBookingModel = new DestinationBooking
            {
               Id = dest.Id,
                AppUserId = appUser.Id
            };

             await  _hotelBookingRepo.CreateAsync(hotelBooking);

            if (hotelBooking == null)
            {
                return StatusCode(500, "Could not create");
            }
            else
            {
                return Created();
            }
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteHotelBookings(string name)
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);

            var userBookings = await  _hotelBookingRepo.GetUserBookings(appUser);

            var filteredbookings = userBookings.Where(s => s.Name.ToLower() == name.ToLower()).ToList();

            if (filteredbookings.Count() >= 1)
            {
                await  _hotelBookingRepo.DeleteBookings(appUser, name);
            }
            else
            {
                return BadRequest("Hotel not in your Bookings");
            }

            return Ok();
        }
    }
}