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
            return View();
        }

        // GET: RenteeController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            id = HttpContext.Session.GetString("username");
            var ren = await _repo.Get(id);
            return View(ren);
        }

        // GET: RenteeController/Create
        public ActionResult Create()
        {
            ViewBag.Genders = GetGender();
            return View();
        }

        // POST: RenteeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Rentee ren)
        {

            try
            {
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

        // GET: RenteeController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            ViewBag.Genders = GetGender();
            var ren = await _repo.Get(id);
            return View(ren);
        }

        // POST: RenteeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Rentee ren)
        {
            try
            {
                ViewBag.Genders = GetGender();
                await _repo.Update(ren);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: RenteeController/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            var ren = await _repo.Get(id);
            return View(ren);
        }

        // POST: RenteeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, Rentee ren)
        {
            try
            {
                await _repo.Delete(id);
                return RedirectToAction("myDash", "User");
            }
            catch
            {
                return View();
            }
        }
    }
}
