using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return Content("Welcome to the Employee Index Page.");
    }
    public IActionResult Details(int id)
    {
        string profile = string.Empty;
        if (id == 1)
        {
            profile = "Ambreen";
        }
        else if (id == 2)
        {
            profile = "Ayesha";
        }
        else if (id == 3)
        {
            profile = "Zainab";
        }
        else
        {
            profile = "No record found";
        }
        return Content($"Details of Employee with ID: {id} — Name: {profile}");
    }
}
