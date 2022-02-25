using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NookMainApp.Models;
using NookMainApp.Services;
using NookMainApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookMainApp.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ISingleUserRepo<string, Appointment> _srepo;
        private readonly IRepo<int, Appointment> _repo;
        private readonly IRepo<string, Rentee> _rrepo;
        private readonly IRepo<string, Renter> _r_repo;

        public AppointmentController(ISingleUserRepo<string, Appointment> srepo, IRepo<int, Appointment> repo, 
            IRepo<string, Rentee> rrepo, IRepo<string, Renter> r_repo)
        {
            _srepo = srepo;
            _repo = repo;
            _rrepo = rrepo;
            _r_repo = r_repo;
        }
        // GET: AppointmentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult CreateAppointment(string userName)
        {
            Appointment appointment = new Appointment {RenteeUserName = userName};

            return View(appointment);
        }

        // POST: AppointmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAppointment(Appointment appointment)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                appointment.RenterUserName = HttpContext.Session.GetString("username");
                var appt = await _repo.Add(appointment);
                if(appt != null)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: AppointmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AppointmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppointmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppointmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
