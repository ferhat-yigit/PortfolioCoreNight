﻿using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatisticComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Testimonials.Count();
            ViewBag.v2 = context.Portfolios.Count();
            ViewBag.v3 = context.Skills.Count();       
            Random rnd = new Random();
            ViewBag.v4 = rnd.Next(10, 20); 
            return View();
        }
    }
}