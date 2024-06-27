using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Wandermate.Extensions;
using Wandermate.Interface;
using Wandermate.Models;
using Wandermate.Repos;

namespace Wandermate.Controllers
{
     [Route("api/DestinationBooking")]
    [ApiController]
    public class DestinationBookingController : ControllerBase
    {   
        private readonly UserManager<AppUser> _userManager;

        private readonly DestinationInterface _destRepo;

        private readonly DestinationBookingsInterface _destBookingRepo;
        public DestinationBookingController(UserManager <AppUser> userManager, DestinationInterface destRepo, DestinationBookingsInterface destBookingRepo)
        {
            _userManager = userManager;
            _destRepo = destRepo;
            _destBookingRepo = destBookingRepo;
        }

         [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUserBookings()
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var userBookings = await _destBookingRepo.GetUserBookings(appUser);
            return Ok(userBookings);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddDestinationBookings(string name)
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var dest = await _destRepo.GetByNameAsync(name);

           

            if (dest == null) return BadRequest("Destination not found");

            var userBooking = await _destBookingRepo.GetUserBookings(appUser);

            if (userBooking.Any(e => e.Name.ToLower() == name.ToLower())) return BadRequest("Cannot add same Destination to bookings");

            var destBookingModel = new DestinationBooking
            {
               Id = dest.Id,
                AppUserId = appUser.Id
            };

             await _destBookingRepo.CreateAsync(destBookingModel);

            if (destBookingModel == null)
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
        public async Task<IActionResult> DeleteDestinationBookings(string name)
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);

            var userBookings = await _destBookingRepo.GetUserBookings(appUser);

            var filteredbookings = userBookings.Where(s => s.Name.ToLower() == name.ToLower()).ToList();

            if (filteredbookings.Count() >= 1)
            {
                await _destBookingRepo.DeleteBookings(appUser, name);
            }
            else
            {
                return BadRequest("Destination not in your Bookings");
            }

            return Ok();
        }
    }
}