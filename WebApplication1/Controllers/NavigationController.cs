using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;
public class NavigationController : Controller
{
    public IActionResult Index()
    {
        return View("Index");
    }
    public IActionResult About()
    {
        return View("About");
    }
    public IActionResult ContactUs()
    {
        return View("ContactUs");
    }
}