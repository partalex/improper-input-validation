using Microsoft.AspNetCore.Mvc;

namespace ImproperInputValidation.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }
}