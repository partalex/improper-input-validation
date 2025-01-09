using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace ImproperInputValidation.Controllers;

public class PathTraversalForFlagAccess : Controller
{
    public IActionResult Index(bool isCorrect)
    {
        return View(isCorrect ? "Correct" : "Incorrect");
    }


    [HttpGet]
    public IActionResult GetFile(string input, bool checkPath = false)
    {
        const string defualtPath = "wwwroot/Data/Milena/";
        if (checkPath)
        {
            if (!Regex.IsMatch(input, @"^(?!\.\.\/)(\.\/)?(\w+\/)*\w+\.txt$")) return Content("Error: Invalid path");
            try
            {
                var fileContent = System.IO.File.ReadAllText(defualtPath + input);
                return Content(fileContent);
            }
            catch (Exception ex)
            {
                return Content("Error: " + ex.Message);
            }
        }

        try
        {
            var fileContent = System.IO.File.ReadAllText(defualtPath + input);
            return Content(fileContent);
        }
        catch (Exception ex)
        {
            return Content("Error: " + ex.Message);
        }
    }
}