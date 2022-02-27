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
    public class RenterController : Controller
    {
        private readonly IRepo<string, Renter> _repo;

        public RenterController(IRepo<string, Renter> repo)
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
            return View();
        }

        // GET: RenterController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            id = HttpContext.Session.GetString("username");
            var ren = await _repo.Get(id);
            //if (ren == null)
            //    return RedirectToAction("Create", "Renter");

            return View(ren);
          
        }

        // GET: RenterController/Create
        public ActionResult Create()
        {
            ViewBag.Genders = GetGender();
            return View();
        }

        // POST: RenteeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Renter ren)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                ViewBag.Genders = GetGender();
                ren.UserId = HttpContext.Session.GetString("username");
                await _repo.Add(ren);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: RenterController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);
            id = HttpContext.Session.GetString("username");

            ViewBag.Genders = GetGender();
            var ren = await _repo.Get(id);
            return View(ren);
        }

        // POST: RenterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Renter ren)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                ViewBag.Genders = GetGender();
                await _repo.Update(ren);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: RenterController/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            var ren = await _repo.Get(id);
            return View(ren);
        }

        // POST: RenterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, Renter ren)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);

                await _repo.Delete(id);
                return RedirectToAction("myDash", "User");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> GetAllRenters()
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            ViewBag.LoginUser = HttpContext.Session.GetString("username");
            var rentees = await _repo.GetAll();
            return View(rentees);
        }

        public async Task<ActionResult> GetRenterDetails(string userId)
        {
            string token = HttpContext.Session.GetString("token");
            _repo.GetToken(token);

            ViewBag.LoginUser = HttpContext.Session.GetString("username");
            var ren = await _repo.Get(userId);
            return View(ren);
        }
    }
}
