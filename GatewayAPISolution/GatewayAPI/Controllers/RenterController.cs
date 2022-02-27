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
    //[Authorize]
    public class RenterController : ControllerBase
    {
        private readonly IRepo<string, RenterDTO> _repo;

        public RenterController(IRepo<string, RenterDTO> repo)
        {
            _repo = repo;
        }

        [Route("GetAllRenters")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RenterDTO>>> IndexAsync()
        {
            var rens = await _repo.GetAll();
            return Ok(rens.ToList());
        }

        [Route("GetRenter")]
        [HttpGet]
        public async Task<ActionResult<RenterDTO>> Details(string id)
        {
            var ren = await _repo.Get(id);
            if (ren == null)
                return BadRequest("No such rentee account");
            return Ok(ren);
        }

        [HttpPost]
        public async Task<ActionResult<RenterDTO>> Create(RenterDTO ren)
        {

            var r = await _repo.Add(ren);
            if (r == null)
                return NotFound();
            return Created("Renter created", ren);

        }

        [HttpPut]
        public async Task<ActionResult<RenterDTO>> Edit(string id, RenterDTO ren)
        {
            var r = await _repo.Update(ren);
            if (r == null)
                return NotFound();
            return Ok(ren);
        }

        [HttpDelete]
        public async Task<ActionResult<RenterDTO>> Delete(string id)
        {
            var ren = await _repo.Delete(id);
            if (ren == null)
                return NotFound();
            return Ok(ren);
        }
    }
}
