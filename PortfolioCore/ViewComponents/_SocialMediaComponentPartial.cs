using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _SocialMediaComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.SocialMedias.ToList();
            return View(values);
        }
    }
}