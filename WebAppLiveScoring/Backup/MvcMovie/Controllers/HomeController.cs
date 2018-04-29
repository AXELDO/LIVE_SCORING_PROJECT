using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // asp-controller="Home" asp-action = "Index"
        {
            return View();
        }

        public IActionResult About() // asp-controller="Home" asp-action = "About"
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() // asp-controller="Home" asp-action = "Contact"
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
