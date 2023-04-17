using Microsoft.AspNetCore.Mvc;

namespace FutureValue.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        ViewBag.Name = "Mary";
        ViewBag.FV = 999999.00;
        return View();
    }
}