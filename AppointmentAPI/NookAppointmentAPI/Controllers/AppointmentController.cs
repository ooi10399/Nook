using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NookAppointmentAPI.Models;
using NookAppointmentAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookAppointmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IRepo<int, Appointment> _repo;

        public AppointmentController(IRepo<int, Appointment> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Appointment>> Get()
        {
            List<Appointment> appointments = _repo.GetAll().ToList();
            if (appointments.Count == 0)
                return BadRequest("No customers found");
            return Ok(appointments);
        }

        [HttpGet]
        [Route("SingleEmployee")]
        public ActionResult<Appointment> Get(int id)
        {
            var appointment = _repo.GetT(id);
            if (appointment == null)
                return NotFound();
            return Ok(appointment);
        }
        [HttpPut]
        public ActionResult<Appointment> Put(int id, Appointment appt)
        {
            var appointment = _repo.Update(appt);
            if (appointment != null)
            {
                return Created("Updated", appointment);
            }
            return NotFound();

        }
        [HttpDelete]
        public ActionResult<Appointment> Delete(int id)
        {
            var appointment = _repo.Delete(id);
            if (appointment != null)
            {
                return NoContent();
            }
            return NotFound(appointment);
        }
        [HttpPost]
        public ActionResult<Appointment> Post(Appointment appointment)
        {
            var appt = _repo.Add(appointment);
            if (appt != null)
            {
                return Created("Appointment Created", appt);
            }
            return BadRequest("Unable to create");
        }
    }
}
