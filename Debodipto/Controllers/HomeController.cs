using Microsoft.AspNetCore.Mvc;
using PortfolioSite.Models;

namespace PortfolioSite.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = PortfolioContent.Create();
        return View(model);
    }
}
