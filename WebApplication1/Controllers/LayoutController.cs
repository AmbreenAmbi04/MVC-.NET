using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class LayoutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [Route("Employees")]
    public IActionResult GetList()
    {
        return View();
    }
    [Route("NewEmployee")]
    public IActionResult AddEmployee()
    {
        return View();
    }
}
