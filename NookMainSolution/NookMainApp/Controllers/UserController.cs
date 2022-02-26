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

        IEnumerable<SelectListItem> GetUserType()
        {
            List<SelectListItem> cats = new List<SelectListItem>();
            cats.Add(new SelectListItem { Text = "Rentee", Value = "Rentee" });
            cats.Add(new SelectListItem { Text = "Renter", Value = "Renter" });
            return cats;
        }

        // GET: UserController/Create
        public ActionResult Register()
        {
            ViewBag.Types = GetUserType();
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
                if(usr != null)
                {
                    HttpContext.Session.SetString("token", usr.Token);
                    HttpContext.Session.SetString("username", usr.Username);
                    if (usr.UserType == "Rentee")
                        return RedirectToAction("Create", "Rentee");
                    if (usr.UserType == "Renter")
                        return RedirectToAction("Create", "Renter");
                }
                var errorMessage = String.Format("Invalid inputs. Email is already registered. Please login or use another account.");
                ModelState.AddModelError(string.Empty, errorMessage);
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
                if (usr != null)
                {
                    HttpContext.Session.SetString("token", usr.Token);
                    HttpContext.Session.SetString("username", usr.Username);
                    if (usr.UserType == "Rentee")
                        return RedirectToAction("Details", "Rentee");
                    if (usr.UserType == "Renter")
                        return RedirectToAction("Details", "Renter");
                }
                var errorMessage = String.Format("Invalid username or password");
                ModelState.AddModelError(string.Empty, errorMessage);
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Logout(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            try
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login", "User");
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
