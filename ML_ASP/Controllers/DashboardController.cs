﻿using Microsoft.AspNetCore.Mvc;

namespace ML_ASP.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Trainee()
        {
            return View();
        }

        public IActionResult FileManagement()
        {
            return View();
        }
    }
}
