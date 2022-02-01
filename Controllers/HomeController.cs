using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission4.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext daContext { get; set; }
        //constructor
        public HomeController(MovieContext someName)
        {
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FillOutMovieForm()
        {
            ViewBag.Categories = daContext.Categories.ToList();
            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult FillOutMovieForm(MovieResponse mr)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(mr);
                daContext.SaveChanges();

                return View("confirmation", mr);
            }
            else // if invalid then send them back to the view with the info they had put in
            {
                ViewBag.Categories = daContext.Categories.ToList();

                return View("MovieForm");
            }
         
        }
        public IActionResult GetPodcasts()
        {
            return View("MyPodcasts");
        }

        public IActionResult MovieTable()
        {
            var applications = daContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            
            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            // this line below is telling what movie you clicked "edit" for
            var application = daContext.responses.Single(x => x.MovieId == movieid);

            return View("MovieForm", application);
        }
        [HttpPost]
        public IActionResult Edit(MovieResponse blah)
        {
            daContext.Update(blah);
            daContext.SaveChanges();

            return RedirectToAction("MovieTable");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var application = daContext.responses.Single(x => x.MovieId == movieid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            daContext.responses.Remove(mr);
            daContext.SaveChanges();
            return RedirectToAction("MovieTable");
        }
    }
}
