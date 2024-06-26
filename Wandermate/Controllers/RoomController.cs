using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Wandermate.Data;
using Wandermate.Dtos.Rooms;
using Wandermate.Mappers;
using Microsoft.EntityFrameworkCore;
using Wandermate.Interface;

namespace Wandermate.Controllers
{[Route("api/rooms")]
    [ApiController]
    public class RoomController : ControllerBase
    {
         private readonly ApplicationDbContext _context;
        private readonly RoomsInterface _roomrepo;
        public RoomController(ApplicationDbContext context, RoomsInterface roomrepo)
        {
            _context = context;
            _roomrepo= roomrepo;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll(){
            var room = await _roomrepo.GetAllAsync();
            var roomdto= room.Select(s=> s.ToRoomsDto());
            return Ok(roomdto);
        }

        [HttpGet("{id}")]

        public async Task <IActionResult> GetById([FromRoute] int id){

            var room = await _roomrepo.GetByIdAsync(id);

            if(room== null){
                return NotFound();
            } else{
                return Ok(room.ToRoomsDto());
            }

        }

        [HttpPost]

        public async Task <IActionResult> Create([FromBody] CreateRoomsRequestDto roomrqDto){
            var roommodel = roomrqDto.ToRoomRequestDto();
            await _roomrepo.CreateAsync(roommodel);
            return CreatedAtAction(nameof(GetById),new {id=roommodel.Id},roommodel.ToRoomsDto());
        }
        
        [HttpPut]

        [Route("{id:int}")]

        public async Task <IActionResult> Update([FromRoute] int id,[FromBody] RoomsUpdateRequestDto updateroom){
            var room= await _roomrepo.UpdateAsync(id, updateroom);
            if(room == null){
                return NotFound();
            }
            
             return Ok(room.ToRoomsDto()); 
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task <IActionResult> Delete([FromRoute] int id){

            var room= await _roomrepo.DeleteAsync(id);
            if (room == null){
                return NotFound();

            }
            return NoContent();
        }
    }
}