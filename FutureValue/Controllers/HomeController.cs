using FutureValue.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValue.Controllers;

public class HomeController : Controller
{   [HttpGet]
    // GET
    public IActionResult Index()
    {
        ViewBag.FV = 0;
        return View();
    }

    [HttpPost]
    public IActionResult Index(FutureValueModel model)
    {
        ViewBag.FV = ModelState.IsValid ? model.CalculateFutureValue() : 0;
        return View(model);
    }
}