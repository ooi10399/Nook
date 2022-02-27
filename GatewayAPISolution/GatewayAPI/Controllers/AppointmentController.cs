using GatewayAPI.Models;
using GatewayAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GatewayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]

    public class AppointmentController : ControllerBase
    {
        private readonly IRepo<int, AppointmentDTO> _repo;
        private readonly ISingleUserRepo<string, AppointmentDTO> _srepo;

        public AppointmentController(IRepo<int, AppointmentDTO> repo, ISingleUserRepo<string, AppointmentDTO> srepo)
        {
            _repo = repo;
            _srepo = srepo;
        }
        [Route("GetUserAppointments")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentDTO>>> IndexAsync(string userName)
        {
            var appointments = await _srepo.GetAll(userName);
            return Ok(appointments.ToList());

        }

        [Route("GetAllAppointments")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentDTO>>> IndexAsync()
        {
            var appointments = await _repo.GetAll();
            return Ok(appointments.ToList());

        }

        [Route("GetAppointment")]
        [HttpGet]
        public async Task<ActionResult<AppointmentDTO>> Details(int id)
        {
            var appointment = await _repo.Get(id);
            if (appointment == null)
                return BadRequest("No such Appointment");
            return Ok(appointment);
        }

        [HttpPost]
        public async Task<ActionResult<AppointmentDTO>> Create(AppointmentDTO appt)
        {
            var appointment = await _repo.Add(appt);
            if (appointment == null)
                return NotFound();
            return Created("Appointment created", appt);
        }

        [HttpPut]
        public async Task<ActionResult<AppointmentDTO>> Put(int id, AppointmentDTO appt)
        {
            var appointment = await _repo.Update(appt);
            if (appointment == null)
                return NotFound();
            return Ok(appt);
        }

        [HttpDelete]
        public async Task<ActionResult<AppointmentDTO>> Delete(int id)
        {
            var appointment = await _repo.Delete(id);
            if (appointment == null)
                return NotFound();
            return Ok(appointment);
        }
    }
}
