using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ValidationController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SubmitData(ValidationModel valid)
    {
        if(ModelState.IsValid)
        {
            return View();
        }
        return View("Index", valid);
    }
}
