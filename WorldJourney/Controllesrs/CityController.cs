using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WorldJourney.Controllesrs
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
