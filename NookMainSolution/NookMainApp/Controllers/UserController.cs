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
        private readonly IRepo<string, Rentee> _rrepo;
        private readonly IRepo<string, Renter> _r_repo;

        public UserController(LoginService loginService, IRepo<string,Rentee> rrepo, IRepo<string, Renter> r_repo)
        {
            _loginService = loginService;
            _rrepo = rrepo;
            _r_repo = r_repo;
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
                    HttpContext.Session.SetString("usertype", usr.UserType);
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
                    HttpContext.Session.SetString("usertype", usr.UserType);

                    if (HttpContext.Session.GetString("token") != null)
                    {
                        string token = HttpContext.Session.GetString("token");

                        _rrepo.GetToken(token);
                        _r_repo.GetToken(token);
                    }

                    var id = HttpContext.Session.GetString("username");
                    if (usr.UserType == "Rentee")
                    {
                        var ren = await _rrepo.Get(id);
                        if (ren == null)
                            return RedirectToAction("Create", "Rentee");
                        return RedirectToAction("Index", "Home");
                    }
                        
                    if (usr.UserType == "Renter")
                    {
                        var ren = await _r_repo.Get(id);
                        if (ren == null)
                            return RedirectToAction("Create", "Renter");
                        return RedirectToAction("Index", "Home");
                    }
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

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "User");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Logout()
        //{
        //    try
        //    {
        //        HttpContext.Session.Clear();
        //        return RedirectToAction("Login", "User");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

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
