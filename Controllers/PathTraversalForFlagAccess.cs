using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class PathTraversalForFlagAccess : Controller
{
    public IActionResult Index(bool isCorrect)
    {
        return View(isCorrect ? "Correct" : "Incorrect");
    }



    [HttpGet]
    public IActionResult GetFile(string input, bool checkPath = false)
    {
        var defualtPath = "wwwroot/Data/Milena/";
        if (checkPath)
        {
            if (Regex.IsMatch(input, @"^(?!\.\.\/)(\.\/)?(\w+\/)*\w+\.txt$"))
            {
                try
                {
                    string fileContent = System.IO.File.ReadAllText(defualtPath + input);
                    return Content(fileContent);
                }
                catch (Exception ex)
                {
                    return Content("Error: " + ex.Message);
                }
            }

            return Content("Error: Invalid path");
        }

        try
        {
            string fileContent = System.IO.File.ReadAllText(defualtPath + input);
            return Content(fileContent);
        }
        catch (Exception ex)
        {
            return Content("Error: " + ex.Message);
        }
    }
}