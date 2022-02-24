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
    public class UserController : Controller
    {
        private readonly LoginService _loginService;

        public UserController(LoginService loginService)
        {
            _loginService = loginService;
        }

        IEnumerable<SelectListItem> GetType()
        {
            List<SelectListItem> cats = new List<SelectListItem>();
            cats.Add(new SelectListItem { Text = "Rentee", Value = "Rentee" });
            cats.Add(new SelectListItem { Text = "Renter", Value = "Renter" });
            return cats;
        }

        // GET: UserController/Create
        public ActionResult Register()
        {
            ViewBag.Types = GetType();
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            try
            {
                User usr = await _loginService.Register(user);
                HttpContext.Session.SetString("token", usr.Token);
                HttpContext.Session.SetString("username", usr.Username);
                if (usr.UserType == "Rentee")
                    return RedirectToAction("Create", "Rentee");
                if (usr.UserType == "Renter")
                    return RedirectToAction("Create", "Renter");
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Create
        public ActionResult Login()
        {
            ViewBag.Types = GetType();
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User user)
        {
            try
            {
                User usr = await _loginService.Login(user);
                HttpContext.Session.SetString("token", usr.Token);
                if (usr.UserType == "Rentee")
                    return RedirectToAction("Details", "Rentee");
                if (usr.UserType == "Renter")
                    return RedirectToAction("Details", "Renter");
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
