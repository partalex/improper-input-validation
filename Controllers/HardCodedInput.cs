using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class HardCodedInput(IConfiguration configuration) : Controller
{
    public IActionResult Index(bool isCorrect)
    {
        return View(isCorrect ? "Correct" : "Incorrect");
    }

    [HttpPost]
    public IActionResult Login(string username, string password, bool safe = false)
    {
        if (safe)
        {
            var storedUsername = configuration["AppSettings:Username"];
            var storedPassword = configuration["AppSettings:Password"];
            if (username == storedUsername && password == storedPassword)
                return View("Dashboard");
            return Content("Invalid login credentials.");
        }

        const string hardCodedUsername = "admin";
        const string hardCodedPassword = "unsafe";
        if (username == hardCodedUsername && password == hardCodedPassword)
            return View("Dashboard");
        return Content("Invalid login credentials.");
    }
}