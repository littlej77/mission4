using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private MovieContext blahContext { get; set; }
        //constructor
        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult FillOutMovieForm ()
        {
            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult FillOutMovieForm(MovieResponse mr )
        {
            blahContext.Add(mr);
            blahContext.SaveChanges();

            return View("confirmation",mr);
        }
        public IActionResult GetPodcasts()
        {
            return View("MyPodcasts");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
