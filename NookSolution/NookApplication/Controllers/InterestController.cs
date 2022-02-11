using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NookApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookApplication.Controllers
{
    public class InterestController : Controller
    {
        static List<Interest> Interests = new List<Interest>()
        {
            new Interest()
            {
                IntId = 1,
                IntName = "Gymming"
            },

            new Interest()
            {
                IntId = 2,
                IntName = "Cycling"
            },

            new Interest()
            {
                IntId = 3,
                IntName = "Cafe-hopping"
            },

            new Interest()
            {
                IntId = 4,
                IntName = "Pottery-making"
            },

            new Interest()
            {
                IntId = 5,
                IntName = "Clubbing"
            },

            new Interest()
            {
                IntId = 6,
                IntName = "Gymming"
            }
        };

        // GET: InterestController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InterestController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InterestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InterestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: InterestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InterestController/Edit/5
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

        // GET: InterestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InterestController/Delete/5
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
