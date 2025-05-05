using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v0 = "İstatistikler";
            ViewBag.v1=context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);
            ViewBag.v3 = context.Skills.Where(x => x.SkillValue>=70).Count();
            ViewBag.v4 = context.Skills.Average(x => x.SkillValue).ToString("F3");
            ViewBag.v5 = context.Experiences.Count();            
            ViewBag.v6 = context.Experiences.Where(x=>x.SubTitle== "Mobil Developer").Count();
            ViewBag.v7 = context.Portfolios.Where(x=>x.CategoryID==2).Count();
            ViewBag.v8 = context.Portfolios.Count();
            ViewBag.v9 = context.Testimonials.Count();
            ViewBag.v10 = context.Categories.Count();
            return View();
        }
    }
}
