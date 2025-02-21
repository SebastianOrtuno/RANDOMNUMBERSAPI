using Microsoft.AspNetCore.Mvc;

namespace RANDOMNUMBERSAPI.Controllers;

public class RandomController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}