using Asp.NetCoreData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.vb = "Hello Viewbag";
            ViewBag.vb1 = 443;
            ViewBag.vb2 = 65.56;
            ViewBag.vb3 = DateTime.Now;
            ViewBag.vb4 = new List<string>()
            {
                "Sanjay Singh",
                "Ajay Singh",
                "Rohan Singh",
                "Saksham Singh",
            };

            ViewData["vd"] = "Hello Viewdata";
            ViewData["vd1"] = 54;
            ViewData["vd2"] = 65.7;
            ViewData["vd3"] = DateTime.Now;
            ViewData["vd4"] = new List<string>()
            {
                "India",
                "Nepal",
                "UK",
                "Kanada",
            };

            TempData["td"] = "Hello Tempdata";
            TempData["td1"] = 642;
            TempData["td2"] = 77.75;
            TempData["td3"] = DateTime.Now;
            TempData["td4"] = new List<int>()
            {
                65,734,374,375
            };

            HttpContext.Session.SetString("City", "Noida");
            HttpContext.Session.SetString("Name", "Sanjay");

            return View();
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
