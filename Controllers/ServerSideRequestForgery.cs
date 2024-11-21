using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ServerSideRequestForgery : Controller
{
    private string[] _blackList = ["Password"];

    public IActionResult Index(bool isCorrect)
    {
        return View(isCorrect ? "Correct" : "Incorrect");
    }

    public IActionResult ViewTable(bool safe = false)
    {
        var queryParams = Request.Query.ToDictionary(q => q.Key, q => q.Value.ToString());
        var selectedHeaders = queryParams.Where(q => q.Value == "true").Select(q => q.Key).ToList();

        if (safe)
            selectedHeaders.RemoveAll(h => _blackList.Contains(h));
        selectedHeaders.Remove("safe");

        var data = DataDict.GetSampleData();

        foreach (var item in data)
        {
            var keys = item.Data.Keys.ToList();
            foreach (var key in keys)
                if (!selectedHeaders.Contains(key))
                    item.Data.Remove(key);
        }

        var table = new Table_SSRF
        {
            Headers = selectedHeaders,
            Data = data
        };
        return View(table);
    }
}