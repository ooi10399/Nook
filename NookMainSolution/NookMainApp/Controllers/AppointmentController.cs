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

        IHttpContextAccessor HttpContextAccessor;

        public AppointmentController(ISingleUserRepo<string, Appointment> srepo, IRepo<int, Appointment> repo, 
            IRepo<string, Rentee> rrepo, IRepo<string, Renter> r_repo)
        {
            _srepo = srepo;
            _repo = repo;
            _rrepo = rrepo;
            _r_repo = r_repo;
        }

        // GET: AppointmentController
        public async Task<ActionResult> AllAppointment()
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            var userName = HttpContext.Session.GetString("username");
            var appointments = await _srepo.GetAll(userName);
            return View(appointments);
        }

        // GET: AppointmentController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            var appt = await _repo.Get(id);
            var rentee = await _rrepo.Get(appt.RenteeUserName);
            if (appt != null)
            {
                var appointment = new AppointmentViewModel
                {
                    AppointmentId = appt.AppointmentId,
                    Fees = rentee.Fee,
                    TotalFees = appt.Fees,
                    StartDateTime = appt.StartDateTime,
                    EndDateTime = appt.EndDateTime,
                    Status = appt.Status,
                    Remark = appt.Remark,
                    Rentee = rentee,
                    RenterUserName = appt.RenterUserName
                };

                return View(appointment);
            }
            return View();
        }

        public async Task<ActionResult> CreateAppointment(string UserId)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            if(HttpContext.Session.GetString("username") != null)
            {
                var ren = await _r_repo.Get(HttpContext.Session.GetString("username"));
                if (ren == null)
                    return RedirectToAction("Create", "Renter");
            }

            var rentee = await _rrepo.Get(UserId);
            var appointment = new AppointmentViewModel {Rentee = rentee, Fees = rentee.Fee};

            return View(appointment);
        }

        // POST: AppointmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAppointment(AppointmentViewModel appointment)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                appointment.RenterUserName = HttpContext.Session.GetString("username");

                bool isRenterApptDuplicated = await CheckingRenterAppointment(appointment.RenterUserName, appointment.StartDateTime, appointment.EndDateTime);
                if (!isRenterApptDuplicated)
                {
                    ViewBag.Message = "Sorry, you already have a appointment on same day and time. Please check.";
                    return View(appointment);
                }
                   
                //bool isRenteeApptDupliated = await CheckingRenteeAppointment(appointment.RenteeUserName, appointment.StartDateTime, appointment.EndDateTime);
                //if (!isRenteeApptDupliated)
                //{
                //    {
                //        ViewBag.Message = "Sorry, " + appointment.RenteeUserName + " is unavailable on this Date. Please try again.";
                //        return View(appointment);
                //    }
                //}

                var appt = new Appointment
                {
                    RenteeUserName = appointment.RenteeUserName,
                    RenterUserName = appointment.RenterUserName,
                    StartDateTime = appointment.StartDateTime,
                    EndDateTime = appointment.EndDateTime,
                    Fees = appointment.TotalFees,
                    PlacementDate = DateTime.Now,
                    Remark = appointment.Remark,
                    UpdateDate = DateTime.Now,
                    Status = Constant.AppointmentStatus.Pending
                };

                var app = await _repo.Add(appt);
                if (app != null)
                {
                    return RedirectToAction("AllAppointment");
                }

                ViewBag.Message = "Oops, please try again.";
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Oops, something is wrong. Please try again later.";
                return View();
            }
        }

        private async Task<bool> CheckingRenteeAppointment(string renteeUserName, DateTime start, DateTime end)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            //check rentee availability
            var appts = await _srepo.GetAll(renteeUserName);
            if (appts != null)
            {
                var upcomingAppointments = appts.Where(a => a.Status != Constant.AppointmentStatus.Cancel && a.StartDateTime > DateTime.Now).ToList();
                var crashAppointment = upcomingAppointments.Where(a => (a.StartDateTime < end && a.EndDateTime > start));

                if (crashAppointment.Any())
                {
                    return false;
                }
            }
            return true;
        }

        private async Task<bool> CheckingRenterAppointment(string userName, DateTime start, DateTime end)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            //check if user with any same datetime appointment
            var appts = await _srepo.GetAll(userName);
            if (appts != null)
            {
                var upcomingAppointments = appts.Where(a => a.Status != Constant.AppointmentStatus.Cancel && a.StartDateTime > DateTime.Now).ToList();
                var crashAppointment = upcomingAppointments.Where(a => (a.StartDateTime < end && a.EndDateTime > start));

                if (crashAppointment.Any())
                {
                    return false;
                }
            }
            return true;
        }

        // GET: AppointmentController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {            
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            var appt = await _repo.Get(id);
            var rentee = await _rrepo.Get(appt.RenteeUserName);
            if(appt != null)
            {
                var appointment = new AppointmentViewModel
                {
                    AppointmentId = appt.AppointmentId,
                    Fees = rentee.Fee,
                    TotalFees = appt.Fees,
                    StartDateTime = appt.StartDateTime,
                    EndDateTime = appt.EndDateTime,
                    Status = appt.Status,
                    Rentee = rentee,
                    Remark = appt.Remark,
                    PlacementDate = appt.PlacementDate,
                    UpdateDate = appt.UpdateDate,
                    RenterUserName = appt.RenterUserName
                };

                return View(appointment);
            }
            return View();
        }

        // POST: AppointmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(AppointmentViewModel appt)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                var newAppt = appt;
                var appointment = await _repo.Get(appt.AppointmentId);
                if(appointment != null)
                {
                    bool isRenterApptDuplicated = await CheckingRenterAppointmentByApptId(appointment, newAppt);
                    if (!isRenterApptDuplicated)
                    {
                        ViewBag.Message = "Sorry, you already have a appointment on same day and time. Please check.";
                        return View(newAppt);
                    }

                    var latestAppt = new Appointment
                    {
                        AppointmentId = newAppt.AppointmentId,
                        RenteeUserName = appointment.RenteeUserName,
                        RenterUserName = appointment.RenterUserName,
                        StartDateTime = newAppt.StartDateTime,
                        EndDateTime = newAppt.EndDateTime,
                        Fees = newAppt.TotalFees,
                        Remark = newAppt.Remark,
                        PlacementDate = appointment.PlacementDate,
                        Status = newAppt.Status,
                        UpdateDate = DateTime.Now
                    };

                    var app = await _repo.Update(latestAppt);
                    if (app != null)
                    {
                        ViewBag.Message = "Appointment updated";
                        return RedirectToAction("AllAppointment");
                    }
                }
               
                ViewBag.Message = "Oops, No such appointment.";
                return RedirectToAction("AllAppointment");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Oops, please try again later.";
                return View();
            }
        }

        private async Task<bool> CheckingRenterAppointmentByApptId(Appointment appointment, AppointmentViewModel newAppt)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            //check if user with any same datetime appointment
            var appts = await _srepo.GetAll(appointment.RenterUserName);
            if (appts != null)
            {
                var upcomingAppointments = appts.Where(a => a.Status != Constant.AppointmentStatus.Cancel && a.StartDateTime > DateTime.Now).ToList();
                //check if datetime, and appointmentId overlape
                var crashAppointment = upcomingAppointments.Where(a => (a.StartDateTime < newAppt.EndDateTime && a.EndDateTime > newAppt.StartDateTime) && a.AppointmentId != newAppt.AppointmentId).ToList();
                
                if (crashAppointment.Any())
                {
                    return false;
                }
            }
            return true;
        }

        // GET: AppointmentController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            var appt = await _repo.Get(id);
            var rentee = await _rrepo.Get(appt.RenteeUserName);
            if (appt != null)
            {
                var appointment = new AppointmentViewModel
                {
                    AppointmentId = appt.AppointmentId,
                    Fees = rentee.Fee,
                    TotalFees = appt.Fees,
                    StartDateTime = appt.StartDateTime,
                    EndDateTime = appt.EndDateTime,
                    Status = appt.Status,
                    Remark = appt.Remark,
                    Rentee = rentee,
                    RenterUserName = appt.RenterUserName
                };

                return View(appointment);
            }
            return View();
        }

        // POST: AppointmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, AppointmentViewModel appointment)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                var appt = await _repo.Delete(id);
                if(appt != null)
                {
                    ViewBag.Message = "Your appointment has been cancel successfully.";
                    return RedirectToAction("AllAppointment");
                }

                ViewBag.Message = "There is no such appointment.";
                return View();

            }
            catch
            {
                ViewBag.Message = "Failed to cancel the appointment.";
                return View();
            }
        }

/*==============This is a line to seperate rentee from renter===================*/

        public async Task<ActionResult> AllRenteeAppointment()
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            var userName = HttpContext.Session.GetString("username");
            var appointments = await _srepo.GetAll(userName);
            
            if (appointments != null)
            {
               return View(appointments);
            }
            return View();
        }
        public async Task<ActionResult> EditRenteeAppointment(int id)
        {
            try
            {                
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                var appt = await _repo.Get(id);
                var renter = await _r_repo.Get(appt.RenterUserName);
                if (appt != null)
                {
                    var appointment = new AppointmentViewModel
                    {
                        AppointmentId = appt.AppointmentId,
                        TotalFees = appt.Fees,
                        StartDateTime = appt.StartDateTime,
                        EndDateTime = appt.EndDateTime,
                        Remark = appt.Remark,
                        Status = appt.Status,
                        Renter = renter
                    };

                    return View(appointment);
                }
                return View();
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditRenteeAppointment(AppointmentViewModel appt)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                var newAppt = appt;
                var appointment = await _repo.Get(appt.AppointmentId);
                if (appointment != null)
                {
                    if(newAppt.Status == Constant.AppointmentStatus.Confirm)
                    {
                        bool isRenteeApptDuplicated = await CheckingRenteeAppointment(appointment, newAppt);
                        if (!isRenteeApptDuplicated)
                        {
                            ViewBag.Message = "Sorry, you already have a appointment on same day and time. Please check.";
                            return View(newAppt);
                        }
                    }

                    var latestAppt = new Appointment
                    {
                        AppointmentId = newAppt.AppointmentId,
                        RenteeUserName = appointment.RenteeUserName,
                        RenterUserName = appointment.RenterUserName,
                        StartDateTime = newAppt.StartDateTime,
                        EndDateTime = newAppt.EndDateTime,
                        Fees = newAppt.TotalFees,
                        PlacementDate = appointment.PlacementDate,
                        Status = newAppt.Status,
                        Remark = newAppt.Remark,
                        UpdateDate = DateTime.Now
                    };

                    var app = await _repo.Update(latestAppt);
                    if (app != null)
                    {
                        ViewBag.Message = "Appointment updated";
                        return RedirectToAction("AllRenteeAppointment");
                    }
                }

                ViewBag.Message = "Oops, No such appointment.";
                return RedirectToAction("AllRenteeAppointment");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Oops, please try again later.";
                return View();
            }
        }

        private async Task<bool> CheckingRenteeAppointment(Appointment appointment, AppointmentViewModel newAppt)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            //check if user with any same datetime appointment
            var appts = await _srepo.GetAll(appointment.RenteeUserName);
            if (appts != null)
            {
                var upcomingAppointments = appts.Where(a => a.Status == Constant.AppointmentStatus.Confirm && a.StartDateTime > DateTime.Now).ToList();
                //check if confirmed datetime, and appointmentId overlape
                var crashAppointment = upcomingAppointments.Where(a => (a.StartDateTime < newAppt.EndDateTime && a.EndDateTime > newAppt.StartDateTime) && a.AppointmentId != newAppt.AppointmentId).ToList();

                if (crashAppointment.Any())
                {
                    return false;
                }
            }
            return true;
        }

        // GET: AppointmentController/Details/5
        public async Task<ActionResult> RenteeAppointmentDetails(int id)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            var appt = await _repo.Get(id);
            var renter = await _r_repo.Get(appt.RenterUserName);
            if (appt != null)
            {
                var appointment = new AppointmentViewModel
                {
                    AppointmentId = appt.AppointmentId,
                    TotalFees = appt.Fees,
                    StartDateTime = appt.StartDateTime,
                    EndDateTime = appt.EndDateTime,
                    Status = appt.Status,
                    Renter = renter,
                    Remark = appt.Remark,
                    PlacementDate = appt.PlacementDate,
                    RenterUserName = appt.RenterUserName
                };

                return View(appointment);
            }
            return View();
        }

        public async Task<ActionResult> DeleteRenteeAppointment(int id)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);
            
            
            var appt = await _repo.Get(id);
            var renter = await _r_repo.Get(appt.RenterUserName);
            if (appt != null)
            {
                var appointment = new AppointmentViewModel
                {
                    AppointmentId = appt.AppointmentId,
                    TotalFees = appt.Fees,
                    StartDateTime = appt.StartDateTime,
                    EndDateTime = appt.EndDateTime,
                    Status = appt.Status,
                    Renter = renter,
                    Remark = appt.Remark,
                    RenterUserName = appt.RenterUserName
                };

                return View(appointment);
            }
            return View();
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteRenteeAppointment(int id, AppointmentViewModel appointment)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                var appt = await _repo.Delete(id);
                if (appt != null)
                {
                    ViewBag.Message = "Your appointment has been cancel successfully.";
                    return RedirectToAction("AllRenteeAppointment");
                }

                ViewBag.Message = "There is no such appointment.";
                return View();

            }
            catch
            {
                ViewBag.Message = "Failed to cancel the appointment.";
                return View();
            }
        }
    }
}
