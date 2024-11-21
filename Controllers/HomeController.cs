using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }
}