﻿using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error404()
        {
            return View("Error404");
        }
    }
}