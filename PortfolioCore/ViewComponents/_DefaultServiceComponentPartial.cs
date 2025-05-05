using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var services = context.Services.OrderByDescending(s => s.ServiceID).Take(6).ToList(); //Take son 6 adet
            return View(services);
        }
    }
}