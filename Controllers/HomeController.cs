using System.Diagnostics;
using BlogApp.DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private BlogRepository _blogRepository;

    public HomeController(ILogger<HomeController> logger,BlogRepository blogRepository)
    {
        _logger = logger;
        _blogRepository = blogRepository;
    }

    public IActionResult Index()
    {
        Console.WriteLine(12);
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

    public IActionResult Test()
    {
        return View();
    }
}