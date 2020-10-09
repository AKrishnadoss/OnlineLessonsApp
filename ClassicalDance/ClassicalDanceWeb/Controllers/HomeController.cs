using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClassicalDanceWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();// "Index", "~/Views/Shared/_Layout.cshtml");
        }
        public IActionResult ContactUs()
        {
            return View();// "Index", "~/Views/Shared/_Layout.cshtml");
        }

    }
}
