﻿using Laba7.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Laba7.Controllers
{
    public class HomeController : Controller
    {
        ShipsContext db = new ShipsContext();

        public ActionResult Index()
        {
            IEnumerable<Ships> flights = db.Ships;
            ViewBag.Flights = flights;
            return View();
        }
    }
}