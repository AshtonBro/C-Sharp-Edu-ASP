using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using WorldJourney.Models;

namespace WorldJourney.Controllesrs
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Page"] = "Search city";
            return View();
        }


        public IActionResult Details()
        {
            ViewData["Page"] = "Selected city";
            City city = null;
            if(city == null)
            {
                return NotFound();
            }
            return View(city);
        }

    }
}
