using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Progcube.Subscriptions.Sample.Models;

namespace Progcube.Subscriptions.Sample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Customers");
        }

        public IActionResult Customers()
        {
            return View();
        }

        public IActionResult Plans()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Discounts()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
