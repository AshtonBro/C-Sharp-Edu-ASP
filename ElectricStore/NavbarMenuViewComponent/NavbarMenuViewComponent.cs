﻿using ElectricStore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricStore.NavbarMenuViewComponent
{
    public class NavbarMenuViewComponent : ViewComponent
    {
        private StoreContext _context;

        public NavbarMenuViewComponent(StoreContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _context.menuCategories.OrderBy(c => c.Name).ToList();
            return View("MenuCategories", categories);
        }
    }
}
