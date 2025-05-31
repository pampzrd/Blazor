using Microsoft.AspNetCore.Mvc;

namespace BlazorSalmos.Components.Layout;

public class Controller1 : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}