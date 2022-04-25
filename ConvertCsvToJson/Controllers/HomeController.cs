using System.Diagnostics;
using ConvertCsvToJson.Models;
using Microsoft.AspNetCore.Mvc;
using Aspose.Cells; 

namespace ConvertCsvToJson.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public void ConvertToJson(string filePath)
    {
        var workbook = new Workbook(filePath);
        workbook.Save("Output.json");
    }
}