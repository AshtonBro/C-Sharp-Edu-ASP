﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiesWebsite.Services;
using Microsoft.AspNetCore.Mvc;

namespace CitiesWebsite.Controllers
{
    public class CityController : Controller
    {
        private ICityProvider _cities;
        public CityController(ICityProvider cities)
        {

        }

        public IActionResult ShowCities()
        {
            ViewBag.Cities = _cities;
            return View();
        }

        public IActionResult ShowDataForCity()
        {
            return View();
        }

        public IActionResult GetImage(string cityName)
        {
            return Content(cityName);
        }
    }
}