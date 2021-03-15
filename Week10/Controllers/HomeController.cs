using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Week10.Models;

namespace Week10.Controllers
{
    public class HomeController : Controller
    {
        private TripLogContext Context { get; set; }

        public HomeController(TripLogContext ctx) => Context = ctx;

        public ViewResult Index()
        {
            var trips = Context.Trips.OrderBy(t => t.StartDate).ToList();
            return View(trips);
        }

    }
}
