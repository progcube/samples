using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Progcube.Subscriptions.Sample.Models;

namespace Progcube.Subscriptions.Sample.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show(Guid id)
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(Guid id)
        {
            return View();
        }

        public IActionResult Delete(Guid id)
        {
            return View();
        }
    }
}
