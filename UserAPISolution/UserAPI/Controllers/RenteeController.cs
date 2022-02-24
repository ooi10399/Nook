using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Models;
using UserAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenteeController : ControllerBase
    {
        private readonly IRepo<int, Rentee> _repo;

        public RenteeController(IRepo<int, Rentee> repo)
        {
            _repo = repo;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<Rentee>> Get()
        {
            List<Rentee> rens = _repo.GetAll().ToList();
            if (rens.Count == 0)
                return BadRequest("No users found");
            return Ok(rens);
        }

        // GET api/<ValuesController>/5
        [HttpGet]
        [Route("SingleUser")]
        public ActionResult<Rentee> Get(int id)
        {
            var ren = _repo.Get(id);
            if (ren == null)
                return NotFound();
            return Ok(ren);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult<Rentee> Post(Rentee rentee)
        {
            var ren = _repo.Add(rentee);
            if (ren != null)
            {
                return Created("User created succesfully", ren);
            }
            return BadRequest("Failed to create user");
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult<Rentee> Put(int id, [FromBody] Rentee rentee)
        {
            var ren = _repo.Update(rentee);
            if (ren != null)
            {
                return Created("Updated", ren);
            }
            return NotFound();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult<Rentee> Delete(int id)
        {
            var ren = _repo.Delete(id);
            if (ren != null)
            {
                return NoContent();
            }
            return NotFound(ren);
        }
    }
}
