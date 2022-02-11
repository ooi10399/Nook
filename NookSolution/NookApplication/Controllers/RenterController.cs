using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NookApplication.Models;
using NookApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookApplication.Controllers
{
    public class RenterController : Controller
    {
        private readonly IRepo<int, Renter> _repo;

        public RenterController(IRepo<int, Renter> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        public IActionResult Details(int id)
        {
            Renter ren = _repo.Get(id);
            return View(ren);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Renter ren)
        {
            _repo.Add(ren);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Renter ren = _repo.Get(id);
            return View(ren);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Renter ren)
        {
            _repo.Update(ren);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Renter ren = _repo.Get(id);
            return View(ren);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, Renter ren)
        {
            _repo.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
