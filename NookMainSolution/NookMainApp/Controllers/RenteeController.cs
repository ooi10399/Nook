using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NookMainApp.Models;
using NookMainApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookMainApp.Controllers
{
    public class RenteeController : Controller
    {
        private readonly IRepo<string, Rentee> _repo;

        public RenteeController(IRepo<string, Rentee> repo)
        {
            _repo = repo;
        }

        IEnumerable<SelectListItem> GetGender()
        {
            List<SelectListItem> cats = new List<SelectListItem>();
            cats.Add(new SelectListItem { Text = "Female", Value = "Female" });
            cats.Add(new SelectListItem { Text = "Male", Value = "Male" });
            return cats;
        }

        // GET: RenteeController
        public async Task<ActionResult> IndexAsync()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");

                _repo.GetToken(token);
                var rens = await _repo.GetAll();
                return View(rens.ToList());
            }

            return RedirectToAction("SessionExpired", "Home");
        }

        // GET: RenteeController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                ViewBag.username = HttpContext.Session.GetString("username");
                id = HttpContext.Session.GetString("username");
                var ren = await _repo.Get(id);
                return View(ren);
            }

            return RedirectToAction("SessionExpired", "Home");

        }

        // GET: RenteeController/Create
        public ActionResult Create()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                ViewBag.Genders = GetGender();
                return View();
            }
            return RedirectToAction("SessionExpired", "Home");
        }

        // POST: RenteeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Rentee ren)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                ViewBag.Genders = GetGender();
                ren.UserId = HttpContext.Session.GetString("username");
                if(ren.Image == null)
                {
                    switch (ren.Gender)
                    {
                        case "Female": ren.Image = "https://restorixhealth.com/wp-content/uploads/2018/08/No-Image.png"; break;
                        case "Male": ren.Image = "https://restorixhealth.com/wp-content/uploads/2018/08/No-Image.png"; break;
                        default: ren.Image = "https://t3.ftcdn.net/jpg/04/34/72/82/360_F_434728286_OWQQvAFoXZLdGHlObozsolNeuSxhpr84.jpg"; break;
                    }
                }
                await _repo.Add(ren);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: RenteeController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);
                id = HttpContext.Session.GetString("username");

                ViewBag.Genders = GetGender();
                var ren = await _repo.Get(id);
                return View(ren);
            }

            return RedirectToAction("SessionExpired", "Home");
        }

        // POST: RenteeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Rentee ren)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                ViewBag.Genders = GetGender();

                var app = await _repo.Update(ren);
                if (app != null)
                {
                    ViewBag.Message = "Details updated";
                    return RedirectToAction("Details");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: RenteeController/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                var ren = await _repo.Get(id);
                return View(ren);
            }

            return RedirectToAction("SessionExpired", "Home");

        }

        // POST: RenteeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, Rentee ren)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);
                id = HttpContext.Session.GetString("username");

                await _repo.Delete(id);
                return RedirectToAction("myDash", "User");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> GetAllRentees()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                ViewBag.LoginUser = HttpContext.Session.GetString("username");
                var rentees = await _repo.GetAll();
                return View(rentees);
            }

            return RedirectToAction("SessionExpired", "Home");

        }

        public async Task<ActionResult> GetRenteeDetails(string id)
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                ViewBag.LoginUser = HttpContext.Session.GetString("username");
                var ren = await _repo.Get(id);
                return View(ren);
            }

            return RedirectToAction("SessionExpired", "Home");

        }
    }
}
