using GatewayAPI.Models;
using GatewayAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatewayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RenteeController : ControllerBase
    {
        private readonly IRepo<string, RenteeDTO> _repo;

        public RenteeController(IRepo<string, RenteeDTO> repo)
        {
            _repo = repo;
        }

        [Route("GetAllRentees")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RenteeDTO>>> IndexAsync()
        {
            var rens = await _repo.GetAll();
            return Ok(rens.ToList());
        }

        [Route("GetRentee")]
        [HttpGet]
        public async Task<ActionResult<RenteeDTO>> Details(string id)
        {
            var ren = await _repo.Get(id);
            if (ren == null)
                return BadRequest("No such rentee account");
            return Ok(ren);
        }

        [HttpPost]
        public async Task<ActionResult<RenteeDTO>> Create(RenteeDTO ren)
        {

            var r = await _repo.Add(ren);
            if (r == null)
                return NotFound();
            return Created("Rentee created", ren);

        }

        [HttpPut]
        public async Task<ActionResult<RenteeDTO>> Edit(string id, RenteeDTO ren)
        {
            var r = await _repo.Update(ren);
            if (r == null)
                return NotFound();
            return Ok(ren);
        }

        [HttpDelete]
        public async Task<ActionResult<RenteeDTO>> Delete(string id)
        {
            var ren = await _repo.Delete(id);
            if (ren == null)
                return NotFound();
            return Ok(ren);
        }
    }
}
