using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultSkillsComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var value = portfolioContext.Skills.ToList();
            return View(value);
        }
    }
}